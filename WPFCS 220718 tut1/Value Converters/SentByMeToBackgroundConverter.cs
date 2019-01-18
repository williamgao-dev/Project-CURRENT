using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Project
{
    /// <summary>
    /// Converts a boolean representing whether a message was sent by this client or not to a brush
    /// </summary>
    public class SentByMeToBackgroundConverter : BaseValueConverter<SentByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Return slightly dark blue if the message was sent by this cient
            // Or very light blue if the message was received

            return (bool)value
                ? Application.Current.FindResource("BackgroundVeryLightBlueBrush")
                : Application.Current.FindResource("BackgroundVeryLightBrush");

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}