using Project.Core;

namespace Project
{
    /// <summary>
    /// Used to locate view models in XAML
    /// </summary>
    public sealed class ViewModelLocator
    {
        #region Singleton 
        public static ViewModelLocator Instance => new ViewModelLocator();
        #endregion

        #region ViewModels

        /// <summary>
        /// Returns the application view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoCContainer.ApplicationViewModel;

        /// <summary>
        /// Returns the settings view model
        /// </summary>
        public static SettingsViewModel SettingsViewModel => IoCContainer.SettingsViewModel;

        #endregion

        #region Constructors
        static ViewModelLocator() { }

        private ViewModelLocator() { }
        #endregion
    }
}
