using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengi.Core
{
    /// <summary>
    /// View model for a menu (eg. Menu that is placed inside of a PopupControl)
    /// </summary>
    public class MenuViewModel : BaseViewModel
    {
        public List<MenuItemViewModel> Items { get; set; }
    }

    /// <summary>
    /// Design time model for a menu
    /// </summary>
    public class MenuDesignViewModel : MenuViewModel
    {
        public static MenuDesignViewModel Instance => new MenuDesignViewModel();

        public MenuDesignViewModel()
        {
            Items = new List<MenuItemViewModel>
            {
                new MenuItemViewModel {Text = "Design time header", Type = MenuItemType.Header},
                new MenuItemViewModel {Icon = IconType.File, Text = "Design menu item 1"},
                new MenuItemViewModel {Icon = IconType.Picture, Text = "Design menu item 2"},
            };
        }
    }
}
