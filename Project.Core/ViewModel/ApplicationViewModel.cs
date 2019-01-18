namespace Project.Core
{
    /// <summary>
    /// View model for the application state.
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// Indicating which page that the application is current on
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// Whether the side menu is visible or not
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;

        /// <summary>
        /// Whether the settings menu is visible
        /// </summary>
        public bool SettingsMenuVisible { get; set; } = false;


    }
}
