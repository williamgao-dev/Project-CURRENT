using System;
using System.Globalization;
using System.Windows;

namespace Bengi
{
    /// <summary>
    ///     Converter that takes a boolean and returns a Visibility.
    /// </summary>
    public class BooleanToVisibilityHiddenConverter : BaseValueConverter<BooleanToVisibilityHiddenConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return value != null && (bool)value ? Visibility.Hidden : Visibility.Visible;
            return value != null && (bool)value ? Visibility.Visible : Visibility.Hidden;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}