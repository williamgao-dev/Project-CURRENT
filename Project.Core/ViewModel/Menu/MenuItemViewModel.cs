using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        public string Text { get; set; }
        public MenuItemType Type { get; set; }
        public IconType Icon { get; set; }
    }
}
