using System.Windows;
using Project.Core;

namespace Project
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {

        #region Private members
        private MessageBoxDialogViewModel mVm;
        #endregion

        #region Public properties
        public MessageBoxDialogViewModel ViewModel
        {
            get
            {
                return mVm;
            }
            set
            {
                mVm = value;
                DataContext = mVm;
            }
        }
        #endregion

        #region Public constructor
        public DialogWindow()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }
        #endregion

    }
}