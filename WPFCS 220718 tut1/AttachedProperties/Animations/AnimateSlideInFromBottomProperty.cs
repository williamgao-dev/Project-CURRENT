using System.Windows;

namespace Project
{
    /// <summary>
    /// Animates framework element up or down on show/hide
    /// </summary>
    public class AnimateSlideInFromBottomProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                await element.SlideAndFadeInFromBottomAsync(firstLoad ? 0 : 0.3f);
            }
            else
            {
                await element.SlideAndFadeOutToBottomAsync(firstLoad ? 0 : 0.3f);
            }
        }
    }
}