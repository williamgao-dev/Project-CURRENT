using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Bengi
{
    /// <summary>
    ///     Base value converter that allows direct XAML usage instead of using resource files
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    // Where T must be a class and can be instantiated
    {
    
        #region Markup Extension Methods

        /// <summary>
        ///     Returns single instance of the value converter
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new T();
        }

        #endregion

        #region Value Converter Methods

        /// <summary>
        ///     The method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        ///     The method to convert a value back from another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}