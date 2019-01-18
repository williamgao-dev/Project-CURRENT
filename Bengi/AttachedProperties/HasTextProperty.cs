using System.Windows;
using System.Windows.Controls;

namespace Bengi
{
    /// <summary>
    /// The HasText attached property for a PasswordBox
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        /// <summary>
        /// Sets property hased on whether the PasswordBox has text
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }
    }
}