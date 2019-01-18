using System;
using System.Diagnostics;
using System.Globalization;
using Project.Core;

namespace Project
{
    /// <summary>
    ///     Converts the ApplicationPage to an actual page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType=null, object parameter=null, CultureInfo culture=null)
        {
            // Ensure that the value passed in is an ApplicationPage
            if (!(value is ApplicationPage page)) return default(object);
            switch (page)
            {
                case ApplicationPage.Login:
                    return new LoginPage();
                case ApplicationPage.Chat:
                    return new ChatPage();
                case ApplicationPage.Register:
                    return new RegisterPage();
                default:
                    Debugger.Break();
                    return null;
            }

            
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}