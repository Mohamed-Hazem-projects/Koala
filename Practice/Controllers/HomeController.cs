using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using System.Diagnostics;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signIn;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, SignInManager<ApplicationUser> user, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this._signIn = user;
            this._userManager = userManager;
        }

        public IActionResult Register()
        {
            ApplicationUser user = new();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUser user)
        {

            var result = await _userManager.CreateAsync(user, user.Password!);
            if (result.Succeeded)
            {
                await _signIn.SignInAsync(user, isPersistent: false);
                return Redirect("/Home/Index");
            }

            return View();
        }

        public IActionResult Login()
        {

            return View();
        }
        //[Authorize]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            //var options = new CookieOptions
            //{
            //    HttpOnly = true,
            //    Expires = DateTime.Now.AddDays(1),
            //    Secure = true
            //};
            //HttpContext.Session.SetString("Ahmed", "10");
            //HttpContext.Response.Cookies.Append("cart", "abc", options);
            //HttpContext.Response.Cookies.Append("cart2", "abc", options);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
