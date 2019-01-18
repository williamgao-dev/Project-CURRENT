using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Bengi
{
    /// <summary>
    ///  Helpers to animate framework elements
    /// </summary>
    public static class FrameworkAnimations
    {
        #region Slide in from left
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds, int width = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideFromLeft(seconds, width == 0 ? element.ActualWidth : width);

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds, int width = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideToRight(seconds, width == 0 ? element.ActualWidth : width);

            // Add fade out animation
            sb.AddFadeOut(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));

            // Make element collapsed
            element.Visibility = Visibility.Collapsed;

        }
        #endregion

        #region Slide in from right
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds, int width = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideFromRight(seconds, width == 0 ? element.ActualWidth : width);

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds, int width = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideToLeft(seconds, width == 0 ? element.ActualWidth : width);

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));

            // Make element collapsed
            element.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Slide up from bottom
        public static async Task SlideAndFadeInFromBottomAsync(this FrameworkElement element, float seconds, int height = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideFromBottom(seconds, height == 0 ? element.ActualHeight : height);

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));
        }
        public static async Task SlideAndFadeOutToBottomAsync(this FrameworkElement element, float seconds, int height = 0)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add animation
            sb.AddSlideToBottom(seconds, height == 0 ? element.ActualHeight : height);

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds*1000));

            element.Visibility = Visibility.Hidden;

        }

        #endregion

        #region Fade in & out
        public static async Task FadeInAsync(this FrameworkElement element, float seconds)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Begin animation
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));
        }
        public static async Task FadeOutAsync(this FrameworkElement element, float seconds)
        {
            // Create storyboard
            var sb = new Storyboard();

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Begin animation
            sb.Begin(element);

            element.Visibility = Visibility.Visible;

            // Wait for animation to finish
            await Task.Delay((int)(seconds * 1000));

            element.Visibility = Visibility.Hidden;

        }

        #endregion
    }
}