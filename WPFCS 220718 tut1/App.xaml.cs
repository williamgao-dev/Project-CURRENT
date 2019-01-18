using System.Windows;
using Project.Core;

namespace Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
       {
            // Let base perform required tasks
            base.OnStartup(e);

            // Setup the main application
            ApplicationSetup();

            // Show main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
        

        /// <summary>
        /// Setup the application
        /// </summary>
        private void ApplicationSetup()
        {
            // Setup
            IoC.Setup();

            // Bind UI manager
            IoC.Kernel.Bind<IUIManager>().ToConstant(new UIManager());


        }
    }
}