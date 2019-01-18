using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Converts a boolean to a <see cref="HorizontalAlignment"/>
    /// </summary>
    public class BooleanToHorizontalAlignmentConverter : BaseValueConverter<BooleanToHorizontalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // If SentByMe is true, align the message to the right, else align it to the left
            return (bool) value ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}