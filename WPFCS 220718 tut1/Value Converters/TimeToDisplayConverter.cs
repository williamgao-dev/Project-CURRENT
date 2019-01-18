using System;
using System.Globalization;

namespace Project
{
    /// <summary>
    /// Converts a date to a user friendly display format
    /// </summary>
    public class TimeToDisplayConverter : BaseValueConverter<TimeToDisplayConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time.Date == DateTimeOffset.UtcNow.Date)
            {
                return time.ToLocalTime().ToString("h:mm tt");
            }
            else
            {
                return time.ToLocalTime().ToString("h:mm tt, dd/MM/yyyy");
            }




        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}