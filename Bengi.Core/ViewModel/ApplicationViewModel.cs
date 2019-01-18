using Ninject;

namespace Bengi.Core
{
    /// <summary>
    /// View model for the application state.
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// Indicating which page that the application is current on
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
        /// <summary>
        /// The view model to use for the current page when the CurrentPage changes
        /// </summary>
        public static BaseViewModel CurrentPageViewModel { get; set; }
        /// <summary>
        /// Whether the side menu is visible or not
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;

        /// <summary>
        /// Whether the settings menu is visible
        /// </summary>
        public bool SettingsMenuVisible { get; set; } = false;
        #endregion

        #region Public Helper Methods
        /// <summary>
        /// Usage: ApplicationViewModel.SwitchToPage(ApplicationPage.X)
        /// </summary>
        /// <param name="ap">The application page to switch to</param>
        public static void GoToPage(ApplicationPage ap, BaseViewModel vm = null)
        {
            // Set the view model
            CurrentPageViewModel = vm;

            // Switch to page passed in
            IoC.Kernel.Get<ApplicationViewModel>().CurrentPage = ap;

            // If chat page is open, also open the side menu
            IoC.Kernel.Get<ApplicationViewModel>().SideMenuVisible = ap == ApplicationPage.Chat;
        }
        #endregion


    }
}
