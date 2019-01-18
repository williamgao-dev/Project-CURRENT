using System;
using System.Windows;

namespace Project
{
    /// <summary>
    /// Base attached property to replace vanilla WPF attached property
    /// </summary>
    /// <typeparam name="TParent">The parent class to be the attached property</typeparam>
    /// <typeparam name="TProperty">Type of the attached property</typeparam>
    public abstract class BaseAttachedProperty<TParent, TProperty>
        where TParent : new()
    {
        #region Public properties

        public static TParent Instance { get; set; } = new TParent();

        #endregion

        #region Public Events

        /// <summary>
        /// Event fired when the value is changed
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = delegate { };

        /// <summary>
        /// Event fired when the value is updated
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = delegate { };


        #endregion

        #region Event methods

        public virtual void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }
        public virtual void OnValueUpdated(DependencyObject d, object value)
        {
        }

        #endregion

        #region Attached Property Definitions
        /// <summary>
        /// The attached property for this class. (accessed in XAML through .Value)
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached(
            "Value",
            typeof(TProperty),
            typeof(BaseAttachedProperty<TParent, TProperty>),
            new PropertyMetadata(default(TProperty),
            new PropertyChangedCallback(OnValuePropertyChanged),
            new CoerceValueCallback(OnValuePropertyUpdated)));

        /// <summary>
        /// Callback event when property is changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (Instance as BaseAttachedProperty<TParent, TProperty>)?.OnValueChanged(d, e);
            (Instance as BaseAttachedProperty<TParent, TProperty>)?.ValueChanged(d, e);
        }

        /// <summary>
        /// Callback event when property is changed even if property is the same value
        /// </summary>
        /// <param name="d"></param>
        /// <param name="value"></param>
        public static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            (Instance as BaseAttachedProperty<TParent, TProperty>)?.OnValueUpdated(d, value);
            (Instance as BaseAttachedProperty<TParent, TProperty>)?.ValueUpdated(d, value);

            return value;
        }

        /// <summary>
        /// Getter for property value
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static TProperty GetValue(DependencyObject d)
        {
            return (TProperty)d.GetValue(ValueProperty);
        }

        /// <summary>
        /// Setter for property value
        /// </summary>
        /// <param name="d"></param>
        /// <param name="value"></param>
        public static void SetValue(DependencyObject d, TProperty value)
        {
            d.SetValue(ValueProperty, value);
        }

        #endregion
    }
}