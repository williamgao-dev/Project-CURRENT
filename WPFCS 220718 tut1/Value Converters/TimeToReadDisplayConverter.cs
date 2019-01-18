using System;
using System.Globalization;

namespace Project
{
    /// <summary>
    /// Converts a date to a user friendly message read display format
    /// </summary>
    public class TimeToReadDisplayConverter : BaseValueConverter<TimeToReadDisplayConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time
            var time = (DateTimeOffset)value;

            // If it is not read
            if (time.Date == DateTimeOffset.MinValue)
            {
                // Show nothing
                return string.Empty;
            }

            if (time.Date == DateTimeOffset.UtcNow.Date)
            {
                return $"Read {time.ToLocalTime().ToString("h:mm tt")}";
            }
            else
            {
                return $"Read {time.ToLocalTime().ToString("h:mm tt, dd/MM/yyyy")}";
            }




        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}