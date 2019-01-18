using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Interaction logic for PopupControl.xaml
    /// </summary>
    public partial class PopupControl : UserControl
    {
        public PopupControl()
        {
            InitializeComponent();
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                this.Background = Brushes.White;
            }
        }
    }
}
