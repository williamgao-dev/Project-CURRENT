using System;
using System.Globalization;
using System.Windows;

namespace Bengi
{
    /// <summary>
    /// Converter that takes a boolean and returns a Visibility.
    /// </summary>
    public class BooleanToVisibilityCollapsedConverter : BaseValueConverter<BooleanToVisibilityCollapsedConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Parameter inverts the converter
            if (parameter == null)
                // If true, collapse the element, else make the element visible
                return (bool)value ? Visibility.Collapsed : Visibility.Visible;

            // If true, make the element visible, else make the element collapsed
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}