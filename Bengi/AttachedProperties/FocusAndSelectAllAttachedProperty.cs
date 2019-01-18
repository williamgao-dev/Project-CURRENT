using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Bengi
{
    /// <summary>
    /// Attached property to focus and select all text inside a textbox
    /// </summary>
    public class FocusAndSelectAllAttachedProperty : BaseAttachedProperty<FocusAndSelectAllAttachedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get text box
            var textBox = (TextBox) d;

            // If new value is true
            if ((bool)e.NewValue)
            {
                // Focus the text box
                textBox.Focus();

                // Select all text inside the text box
                textBox.SelectAll();
            }

        }
    }
}
