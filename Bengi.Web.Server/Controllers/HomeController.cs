using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Bengi.Web.Server
{
    public class HomeController : Controller
    {
        #region Protected members
        /// <summary>
        /// Scoped app db context
        /// </summary>
        protected ApplicationDbContext mContext;
        /// <summary>
        /// Scoped user manager
        /// </summary>
        protected UserManager<ApplicationUser> mUserManager;
        /// <summary>
        /// Scoped sign in manager
        /// </summary>
        protected SignInManager<ApplicationUser> mSignInManager;
        #endregion

        /// <summary>
        /// ctor, managers and context are passed in through DI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public HomeController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            mContext = context;
            mUserManager = userManager;
            mSignInManager = signInManager;
        }
        public IActionResult Index()
        {
            // Make sure mContext is created
            mContext.Database.EnsureCreated();

            return View("Index");
        }

        [Route("logout")]
        public async Task<IActionResult> LogOutAsync()
        {
            // Make sure mContext is created
            await mSignInManager.SignOutAsync();
            return Content("signed out", "text/html");
        }

        public IActionResult Error()
        {
            return View();
        }

        /// <summary>
        /// Creates a single user
        /// </summary>
        /// <returns></returns>
        [Route("create")]
        public async Task<IActionResult> CreateUserAsync()
        {
            var result = await mUserManager.CreateAsync(new ApplicationUser
            {
                UserName = "William",
                Email = "willplaya48@gmail.com"
            }, "password");

            if (result.Succeeded)
            {
                return Content("User was created");
            }
            else
            {
                return Content("User not created");
            }
            await Task.Delay(0);
            return Content("User was created", "text/html");

           
        }

        /// <summary>
        /// Private area that requires auth.
        /// </summary>
        /// <returns></returns>
        /// Authorise requires the cookie to be authenticated.
        [Authorize]
        [Route("private")]
        public IActionResult Private()
        {
            return Content($"This is a private area. Welcome {HttpContext.User.Identity.Name}", "text/html");
        }

        /// <summary>
        /// The auto login page for testing
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [Route("login")]
        public async Task<IActionResult> Login(string returnUrl)
        {
            var result = await mSignInManager.PasswordSignInAsync("william", "password", true, false);

            if (result.Succeeded)
                return Redirect("Home/Index");
            return Content("login failed", "text/html");
        }
    }
}
