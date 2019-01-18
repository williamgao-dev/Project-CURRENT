using System.Threading.Tasks;
using System.Windows.Input;

namespace Bengi.Core
{
    public class RegisterPageViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Flag indicating whether register is running
        /// </summary>
        public bool RegisterCommandRunning { get; set; }
        #endregion


        #region Commands
        /// <summary>
        /// Command that is run when register button is executed
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        /// <summary>
        /// "I already have an account" button command
        /// </summary>
        public ICommand SwitchToLoginPageCommand { get; set; }
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterPageViewModel()
        {
            RegisterCommand = new RelayParameterizedCommand(async(param) => await RegisterAsync(param));
            SwitchToLoginPageCommand = new RelayCommand(() =>
                {
                    ApplicationViewModel.GoToPage(ApplicationPage.Login);
                });
        }

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            // If register is running 
            if (RegisterCommandRunning) return;

            // Try to register
            try
            {

                // Now running 
                RegisterCommandRunning = true;

                // Perform actions
                await Task.Delay(2000);
                var email = Email;
                var pass = (parameter as IHavePassword)?.SecurePassword.Unsecure();
            }
            finally
            {
                // Always runs regardless of the flow of control of the try block
                RegisterCommandRunning = false;

            }

        }
    }
}
