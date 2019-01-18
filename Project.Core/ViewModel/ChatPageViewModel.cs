using System.Windows.Input;

namespace Project.Core
{
    public class ChatPageViewModel : BaseViewModel
    {

        #region Public commands
        /// <summary>
        /// Command that runs when the attach button is clicked
        /// </summary>
        public ICommand AttachCommand { get; set; }
        /// <summary>
        /// Command that runs when the emoji button is clicked
        /// </summary>
        public ICommand EmojiCommand { get; set; }
        /// <summary>
        /// Command that sets all popups visibility to collapsed
        /// </summary>
        public ICommand AllPopupsCollapsedCommand { get; set; }
        /// <summary>
        /// Command that is run when the send button is clicked
        /// </summary>
        public ICommand SendCommand { get; set; }
        /// <summary>
        /// Opens the settings menu
        /// </summary>
        public ICommand SettingsCommand { get; set; }

        #endregion

        #region Public properties
        /// <summary>
        /// Whether the attach menu is visible or not
        /// </summary>
        public bool AttachmentMenuVisible { get; set; }
        /// <summary>
        /// Whether the emoji menu is visible or not
        /// </summary>
        public bool EmojiMenuVisible { get; set; }
        public bool AnyPopupVisible => IsAnyPopupsVisible();

        /// <summary>
        /// Vm for attachment popup menu
        /// </summary>
        public AttachmentPopupMenuViewModel AttachmentPopupMenuViewModel { get; set; }
        /// <summary>
        /// Vm for emoji popup menu
        /// </summary>
        public EmojiPopupMenuViewModel EmojiPopupMenuViewModel { get; set; }

        public string Content { get; set; }
        #endregion

        #region Default constructor
        public ChatPageViewModel()
        {
            // Create viewmodel for attachment popup
            AttachmentPopupMenuViewModel = new AttachmentPopupMenuViewModel();
            // Create viewmodel for emoji popup
            EmojiPopupMenuViewModel = new EmojiPopupMenuViewModel();

            // Create commands
            AttachCommand = new RelayCommand(Attach);
            AllPopupsCollapsedCommand = new RelayCommand(CollapsePopups);
            EmojiCommand = new RelayCommand(Emoji);
            SendCommand = new RelayCommand(Send);
            SettingsCommand = new RelayCommand(() => IoCContainer.ApplicationViewModel.SettingsMenuVisible = true);
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Function that runs when the AttachBuittonCommand is 
        /// </summary>
        public void Attach()
        {
            // Toggle attach menu visibility
            AttachmentMenuVisible ^= true;
        }

        public void Send()
        {
            //// Send ShowMessageBox
            //IoCContainer.UI.ShowMessageBox(new MessageBoxDialogViewModel
            //{
            //    Message = "Thank you for your amazing message",
            //    OkButtonText = "Ok",
            //    Title = "Title of this amazing message",
            //    Content = "Send",
            //});
            IoCContainer.ApplicationViewModel.SettingsMenuVisible = true;
        }

        public void CollapsePopups()
        {
            // Collapse all popup menus
            AttachmentMenuVisible = false;
            EmojiMenuVisible = false;
        }

        public void Emoji()
        {
            // Toggle emoji menu visibility
            EmojiMenuVisible ^= true;
        }

        public bool IsAnyPopupsVisible()
        {
            // If all popups are not visible, return false
            if (EmojiMenuVisible == AttachmentMenuVisible == false)
            {
                return false;
            }

            // If any popups are visible, return true
            return false;
        }
        #endregion

    }
}
