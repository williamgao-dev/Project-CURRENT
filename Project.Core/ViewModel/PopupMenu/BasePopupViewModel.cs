using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Project.Core
{
    /// <summary>
    /// A view model for PopupControl
    /// </summary>
    public class BasePopupViewModel : BaseViewModel
    {
        #region Public properties
        /// <summary>
        /// RGB string for the bubble background. This will be converted in XAML
        /// </summary>
        public string BubbleBackgroundRGB { get; set; }
        /// <summary>
        /// Arrow alignment. This will be converted in XAML
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }
        /// <summary>
        /// The content of this bubble control
        /// This is usually a MenuViewModel
        /// </summary>
        public BaseViewModel Content { get; set; }
        #endregion

        public BasePopupViewModel()
        {
        }

    }

    /// <summary>
    /// Design model for base popup
    /// </summary>
    public class BasePopupDesignViewModel : BasePopupViewModel
    {
        #region Instance
        public static BasePopupDesignViewModel Instance => new BasePopupDesignViewModel();
        #endregion

        #region Public constructor
        public BasePopupDesignViewModel()
        {
            BubbleBackgroundRGB = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;

            Content = new AttachmentPopupMenuDesignViewModel();

        }
        #endregion
    }
}
