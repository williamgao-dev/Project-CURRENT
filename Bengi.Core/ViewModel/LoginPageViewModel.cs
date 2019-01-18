using System.Threading.Tasks;
using System.Windows.Input;

namespace Bengi.Core
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        ///     User email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Flag indicating whether login process is active
        /// </summary>
        public bool LoginCommandRunning { get; set; }
        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }
        public ICommand SwitchToRegisterPageCommand { get; set; }

        #endregion

        #region Private members

        #endregion

        #region .ctor

        public LoginPageViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async parameter => await LoginAsync(parameter));
            SwitchToRegisterPageCommand = new RelayCommand(() => { Register(); });


        }
        #endregion

        #region Register User
        public void Register()
        {
            // Go to register page?
            ApplicationViewModel.GoToPage(ApplicationPage.Register);

        }
        #endregion

        #region Login User

        /// <summary>
        ///     Attempts to login the user
        /// </summary>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            if (LoginCommandRunning) return;

            try
            {
                LoginCommandRunning = true;
                await Task.Delay(1000);
                var email = Email;
                var pass = (parameter as IHavePassword)?.SecurePassword.Unsecure();
                ApplicationViewModel.GoToPage(ApplicationPage.Chat);
            }
            finally
            {
                LoginCommandRunning = false;
            }

        }
        #endregion
    }
}