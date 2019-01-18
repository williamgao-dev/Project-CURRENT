using System;
using System.Globalization;
using System.Windows.Media;

namespace Project
{
    /// <summary>
    /// Converter that takes in a string in RGB hex form, such as FF00FF, and converts it into a WPF color brush.
    /// </summary>
    public class StringRGBToColorBrushConverter : BaseValueConverter<StringRGBToColorBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convert a string as a SolidColourBrush. 
            // #RRGGBB
            return (SolidColorBrush) (new BrushConverter().ConvertFrom($"#{(string) value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new ArgumentException("Invalid.");
        }
    }
}
