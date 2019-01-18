using System.Collections.Generic;

namespace Bengi.Core
{

    /// <summary>
    /// View model for attachment popup menu. This inherits from BasePopupViewModel
    /// </summary>
    public class AttachmentPopupMenuViewModel : BasePopupViewModel
    {
        #region Public properties

        #endregion

        #region Public constructor
        public AttachmentPopupMenuViewModel()
        {
            BubbleBackgroundRGB = "e5e4e8";

            ArrowAlignment = ElementHorizontalAlignment.Right;
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>
                {
                    new MenuItemViewModel {Text = "Attach a file...", Type = MenuItemType.Header},
                    new MenuItemViewModel{ Icon = IconType.File, Text="From computer", Type = MenuItemType.TextAndIcon},
                    new MenuItemViewModel{ Icon = IconType.Picture, Text="From pictures", Type = MenuItemType.TextAndIcon},
                }
            };


        }
        #endregion
    }

    /// <summary>
    /// Design time model for attachment popup menu
    /// </summary>
    public class AttachmentPopupMenuDesignViewModel : AttachmentPopupMenuViewModel
    {
        #region Instance
        /// <summary>
        /// Singleton to be used in XAML design time
        /// </summary>
        public static AttachmentPopupMenuDesignViewModel Instance => new AttachmentPopupMenuDesignViewModel();
        #endregion

        #region Public constructor
        public AttachmentPopupMenuDesignViewModel()
        {
            BubbleBackgroundRGB = "ff0000";
            ArrowAlignment = ElementHorizontalAlignment.Left;
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>
                {
                    new MenuItemViewModel {Text = "Attach a file...", Type = MenuItemType.Header},
                    new MenuItemViewModel{ Icon = IconType.File, Text="From computer"},
                    new MenuItemViewModel{ Icon=IconType.Picture, Text="From pictures"},
                }
            };
        }
        #endregion
    }
}
