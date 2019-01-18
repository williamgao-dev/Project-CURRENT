using System.Windows;
using System.Windows.Controls;

namespace Project
{
    /// <summary>
    /// Scrolls a ScrollViewer to the bottom
    /// </summary>
    public class ScrolledToBottomScrollViewerAttachedProperty : BaseAttachedProperty<ScrolledToBottomScrollViewerAttachedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Scroll to bottom
            (d as ScrollViewer)?.ScrollToBottom();
        }
    }

}