using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Bengi
{
    /// <summary>
    /// Attached property to ensure that the default WPF navigation bar does not show up, and that a frames
    /// navigations service does not ever have entry to disable the usage of ALT + LEFT/RIGHT does not work to
    /// navigate between pages.
    /// </summary>
    public class NoFrameHistoryAttachedProperty : BaseAttachedProperty<NoFrameHistoryAttachedProperty, bool>
    {
        /// <summary>
        /// See parent <see cref="BaseAttachedProperty{TParent,TProperty}"/> documentation.
        /// </summary>
        /// <param name="d">The Frame</param>
        /// <param name="e"></param>
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Disable default UI bar
            if (d is Frame frame)
            {
                // Hide the navigation (back and forward arrows) bar that is default shown
                frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

                // Remove navigation history to ensure it's always cleared.
                frame.Navigated += (sender, args) => (sender as Frame)?.NavigationService.RemoveBackEntry();
            }
        }
    }
}
