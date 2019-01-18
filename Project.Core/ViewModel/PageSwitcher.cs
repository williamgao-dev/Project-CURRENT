using Ninject;
using Project.Core;

namespace Project
{
    public static class PageSwitcher
    {
        public static void SwitchToPage(ApplicationPage ap)
        {
            // Switch to page passed in
            IoC.Kernel.Get<ApplicationViewModel>().CurrentPage = ap;

            // If chat page is open, also open the side menu
            IoC.Kernel.Get<ApplicationViewModel>().SideMenuVisible = ap == ApplicationPage.Chat;
        }
    }
}
