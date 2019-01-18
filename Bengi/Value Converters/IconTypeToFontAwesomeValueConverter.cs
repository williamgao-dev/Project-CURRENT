using Bengi.Core;
using System;
using System.Globalization;

namespace Bengi
{
    /// <summary>
    /// Converts a IconType to a FontAwesome unicode string 
    /// </summary>
    public class IconTypeToFontAwesomeValueConverter : BaseValueConverter<IconTypeToFontAwesomeValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IconType?)value)?.ToFontAwesome();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
