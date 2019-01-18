using System.Windows.Controls;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            DataContext = IoCContainer.SettingsViewModel;
        }
    }
}
