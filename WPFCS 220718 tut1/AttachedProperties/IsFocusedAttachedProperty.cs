using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project
{
    public class IsFocusedAttachedProperty : BaseAttachedProperty<IsFocusedAttachedProperty, bool> 
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is Control control)) return;

            control.Loaded += (s, ee) => { control.Focus(); };

        }
    }
}
