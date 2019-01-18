using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Converts a 
    /// </summary>
    public class StringToDialogContentValueConverter : BaseValueConverter<StringToDialogContentValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string) value)
            {
                case "Send":
                    return new DialogMessageBox();
                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}