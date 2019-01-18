using System.Windows.Controls;
using Project.Core;

namespace Project
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
