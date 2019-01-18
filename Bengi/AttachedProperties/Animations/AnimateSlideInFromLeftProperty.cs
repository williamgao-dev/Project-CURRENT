using System.Windows;

namespace Bengi
{
    /// <summary>
    /// Animates framework element sliding it in left or right
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                await element.SlideAndFadeInFromLeftAsync(firstLoad ? 0 : 0.3f);
            }
            else
            {
                await element.SlideAndFadeOutToLeftAsync(firstLoad ? 0 : 0.3f);
            }
        }
    }
}
