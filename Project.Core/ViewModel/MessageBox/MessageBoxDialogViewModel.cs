using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Project.Core
{
    /// <summary>
    /// Vm for a message box dialog
    /// </summary>
    public class MessageBoxDialogViewModel
    {
        #region Public properties
        /// <summary>
        /// The title of the message box
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The message of the message box
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Text for the "OK" or similar button
        /// </summary>
        public string OkButtonText { get; set; }
        /// <summary>
        /// The content of this dialog window
        /// </summary>
        public string Content { get; set; }
        #endregion

        #region Public commands
        public ICommand CloseCommand { get; set; }
        #endregion

        #region Public constructor
        public MessageBoxDialogViewModel()
        {
            this.CloseCommand = new RelayParameterizedCommand((parameter) => { (parameter as Window)?.Close(); });
        }
        #endregion
    }
}
