using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Bengi.Core
{
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Given an expression, gets its return value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> exp) => exp.Compile().Invoke();

        /// <summary>
        /// Given an expression, sets its return value.
        /// </summary>
        /// <typeparam name="T">Type of the property</typeparam>
        /// <param name="exp"></param>
        /// <param name="valueToSet">Value to set property</param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> exp, T valueToSet)
        {
            // Gets the body of the expression, then gets the property.
            var expression = exp.Body as MemberExpression;

            // Gets property info
            var propertyInfo = (PropertyInfo) expression?.Member;
            var target = Expression.Lambda(expression?.Expression ?? throw new InvalidOperationException()).Compile().DynamicInvoke();

            // Sets property with value passed in 
            propertyInfo?.SetValue(target, valueToSet);
        }
    }
}
