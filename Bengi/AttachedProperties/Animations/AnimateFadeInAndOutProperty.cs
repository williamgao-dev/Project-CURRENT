using System.Windows;

namespace Bengi
{
    /// <summary>
    /// Animates framework element fading in/out
    /// </summary>
    public class AnimateFadeInAndOutProperty : AnimateBaseProperty<AnimateFadeInAndOutProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
        {
            if (value)
            {
                await element.FadeInAsync(firstLoad ? 0 : 0.3f);
            }
            else
            {
                await element.FadeOutAsync(firstLoad ? 0 : 0.3f);
            }


        }
    }
}