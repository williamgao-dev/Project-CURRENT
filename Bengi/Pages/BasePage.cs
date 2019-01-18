using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Bengi.Core;

namespace Bengi
{
    public class BasePage : UserControl
    {

        #region .ctor
        public BasePage()
        {
            // If designer is calling this ctor, simply return.
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            Loaded += BasePage_LoadedAsync;
        }

        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
            {
                await AnimateOut();
            }
            else
            {
               await AnimateIn();
            }
        }

        #endregion

        #region Public properties

        /// <summary>
        /// The amt of time the animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.3f;

        /// <summary>
        /// Flag indicating whether the page should animate out or not
        /// </summary>
        public bool ShouldAnimateOut { get; set; }


        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// When page animates in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            {
                await this.SlideAndFadeInFromRightAsync(SlideSeconds, width: (int)Application.Current.MainWindow.Width);
            }
        }

        /// <summary>
        /// When page animates out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            {
                await this.SlideAndFadeOutToLeftAsync(SlideSeconds, width: (int)Application.Current.MainWindow.Width);
            }
        }

        #endregion

    }

    public class BasePage<TVm> : BasePage
        where TVm : BaseViewModel, new()

    {

        #region Public properties

        public TVm ViewModel { get; set; }

        #endregion

        #region .ctor

        public BasePage()
        {
            // Sets the data context for this page
            ViewModel = new TVm();
            DataContext = ViewModel;
        }

        #endregion
    }
}