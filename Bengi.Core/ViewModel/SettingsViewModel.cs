using System.Windows.Input;

namespace Bengi.Core
{
    /// <summary>
    /// View model for the settings menu
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {

        #region Public properties
        public TextInputViewModel Name { get; set; }
        public TextInputViewModel Email { get; set; }
        public TextInputViewModel Password { get; set; }
        public TextInputViewModel Username { get; set; }
        #endregion

        #region Public commands
        /// <summary>
        /// Closes the menu
        /// </summary>
        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// Opens the menu
        /// </summary>
        public ICommand OpenCommand { get; set; }


        #endregion

        #region Public constructor

        public SettingsViewModel()
        {
            // Create close command
            CloseCommand = new RelayCommand(Close);
            
            // Create open command
            OpenCommand = new RelayCommand(Open);

            // Create text input view models
            // TODO: Remove this dummy data and replace with real information pulled from server
            Name = new TextInputViewModel("Name ");

            Username = new TextInputViewModel("Username ");

            Password = new TextInputViewModel("Password ");

            Email = new TextInputViewModel("Email ");

            Name.EditingText = "William Gao";
            Username.EditingText = "WillPlaya";
            Password.EditingText = "**********";
            Email.EditingText = "willgaobusiness@gmail.com";


        }
        #endregion

        #region Command methods
        /// <summary>
        /// Closes the settings menu.
        /// </summary>
        private void Close()
        {
            // Set settings menu visibility to false
            IoCContainer.ApplicationViewModel.SettingsMenuVisible = false;
        }
        /// <summary>
        /// Opens the settings menu.
        /// </summary>
        private void Open()
        {
            // Set settings menu visibility to true
            IoCContainer.ApplicationViewModel.SettingsMenuVisible = true;
        }
        #endregion


    }
}
