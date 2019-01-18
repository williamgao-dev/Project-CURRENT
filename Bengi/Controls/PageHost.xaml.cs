using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Bengi.Core;

namespace Bengi
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    { 
        #region .ctor
        /// <summary>
        /// Default constructor
        /// </summary>
        public PageHost()
        {
            // If design mode, get CurrentPage and return it

            InitializeComponent();
        }

        #endregion


        public static readonly DependencyProperty CurrentPageProperty = DependencyProperty.Register("CurrentPage",
            typeof(BasePage), typeof(PageHost), new PropertyMetadata(CurrentPagePropertyChanged));

        public BasePage CurrentPage
        {
            get => (BasePage) GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the frames of the pages.
            var oldPageFrame = (d as PageHost)?.OldPage;
            var newPageFrame = (d as PageHost)?.NewPage;

            // Get the content of the current frame
            var oldPageContent = newPageFrame.Content;

            if (oldPageContent is BasePage bp)
            {
                // Tell old page to animate out
                bp.ShouldAnimateOut = true;

                // Once it is done, remove it
                Task.Delay((int)(bp.SlideSeconds * 1000)).ContinueWith((t) => { Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null); });
            }

            oldPageFrame.Content = oldPageContent;

            newPageFrame.Content = e.NewValue;
        }
    }
}
