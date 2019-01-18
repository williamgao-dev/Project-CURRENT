using System.Windows.Controls;
using Project.Core;

namespace Project
{
    /// <summary>
    /// Interaction logic for ChatListControl.xaml
    /// </summary>
    public partial class ChatListControl : UserControl
    {
        public ChatListControl()
        {
            DataContext = new ChatListViewModel();
            InitializeComponent();
        }
    }
}
