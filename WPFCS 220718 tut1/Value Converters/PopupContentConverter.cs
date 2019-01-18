using System;
using System.Diagnostics;
using System.Globalization;
using Project.Core;

namespace Project
{
    /// <summary>
    /// Converter that takes in a BaseViewModel and returns the specific UI control that the passed in viewmodel should be used for
    /// </summary>
    public class PopupContentConverter : BaseValueConverter<PopupContentConverter>
    {
        public override object Convert(object value, Type targetType=null, object parameter=null, CultureInfo culture=null)
        {
            if (value is MenuViewModel menuVm)
                return new MenuVertical {DataContext = menuVm};

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}