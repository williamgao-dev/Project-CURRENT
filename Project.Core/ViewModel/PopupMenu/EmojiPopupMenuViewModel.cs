using System.Collections.Generic;

namespace Project.Core
{

    /// <summary>
    /// View model for emoji popup menu. This inherits from BasePopupViewModel
    /// </summary>
    public class EmojiPopupMenuViewModel : BasePopupViewModel
    {
        #region Public properties

        #endregion

        #region Public constructor
        public EmojiPopupMenuViewModel()
        {
            BubbleBackgroundRGB = "e5e4e8";

            ArrowAlignment = ElementHorizontalAlignment.Left;
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>
                {
                    new MenuItemViewModel {Text = "Attach an emoji...", Type = MenuItemType.Header},
                    new MenuItemViewModel{ Icon = IconType.File, Text="From computer", Type = MenuItemType.TextAndIcon},
                    new MenuItemViewModel{ Icon = IconType.Picture, Text="From pictures", Type = MenuItemType.TextAndIcon},
                }
            };
        }
        #endregion
    }

    /// <summary>
    /// Design time model for emoji popup menu
    /// </summary>
    public class EmojiPopupMenuDesignViewModel : EmojiPopupMenuViewModel
    {
        #region Instance
        /// <summary>
        /// Singleton to be used in XAML design time
        /// </summary>
        public static EmojiPopupMenuDesignViewModel Instance => new EmojiPopupMenuDesignViewModel();
        #endregion

        #region Public constructor
        public EmojiPopupMenuDesignViewModel()
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
