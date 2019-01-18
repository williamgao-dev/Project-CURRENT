using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Value converter that takes in a MenuItemType and a parameter, compares the value and the parameter to ensure
    /// correct conversion, and returns an appropiate <see cref="Visibility"/>
    /// </summary>
    public class MenuItemTypeVisibilityConverter : BaseValueConverter<MenuItemTypeVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // if we have no parameter, return collapsed
            if (parameter == null)
                return Visibility.Collapsed;

            // if enum cannot be parsed, return collapsed
            if (!Enum.TryParse(parameter as string, out MenuItemType param))
                return Visibility.Collapsed;

            return (MenuItemType) value == param ? Visibility.Visible : Visibility.Collapsed;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}