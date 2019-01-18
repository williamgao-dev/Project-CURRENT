using System;
using System.Globalization;
using System.Windows;

namespace Bengi
{
    /// <summary>
    /// Converts a core HorizontalAlignment to a WPF HorizontalAlignment
    /// </summary>
    public class HorizontalAlignmentConverter : BaseValueConverter<HorizontalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
        {
            return (HorizontalAlignment)value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}