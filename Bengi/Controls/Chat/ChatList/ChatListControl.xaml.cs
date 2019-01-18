using System.Windows.Controls;
using Bengi.Core;

namespace Bengi
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
