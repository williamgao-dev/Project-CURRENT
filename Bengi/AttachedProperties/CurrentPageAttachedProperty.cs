using System.Threading.Tasks;
using System.Windows;

namespace Bengi
{
    public class CurrentPageAttachedProperty : BaseAttachedProperty<CurrentPageAttachedProperty, BasePage>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the frames of the pages.
            var oldPageFrame = (d as PageHost)?.OldPage;
            var newPageFrame = (d as PageHost)?.OldPage;

            // Get the content of the current frame
            var oldPageContent = newPageFrame.Content;

            if (oldPageContent is BasePage bp)
            {
                // Tell old page to animate out
                bp.ShouldAnimateOut = true;

                // Once it is done, remove it
                Task.Delay((int) (bp.SlideSeconds * 1000)).ContinueWith((t) => { Application.Current.Dispatcher.Invoke(()=>oldPageFrame.Content = null); });
            }

            oldPageFrame.Content = oldPageContent;

            newPageFrame.Content = e.NewValue;
        }
    }
}
