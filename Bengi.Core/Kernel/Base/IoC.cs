using Ninject;

namespace Bengi.Core
{
    public static class IoCContainer
    {
        /// <summary>
        /// The application view model for this application
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel { get; set; } =
            IoC.Kernel.Get<ApplicationViewModel>();
        /// <summary>
        /// The settings view model for this application
        /// </summary>
        public static SettingsViewModel SettingsViewModel { get; set; } =
            IoC.Kernel.Get<SettingsViewModel>();

        public static IUIManager UI => IoC.Kernel.Get<IUIManager>();
    }
    public class IoC
    {
        #region Kernel
        /// <summary>
        /// Kernel for IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();
        #endregion

        #region Setup
        /// <summary>
        /// Sets up the IoC container, and binds all information required.
        /// </summary>
        public static void Setup()
        {
            // Bind all needed viewmodels
            BindViewModels();

        }

        private static void BindViewModels()
        {
            // Bind to a constant instance of an ApplicationViewModel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
            Kernel.Bind<SettingsViewModel>().ToConstant(new SettingsViewModel());

        }
        #endregion
    }
}
