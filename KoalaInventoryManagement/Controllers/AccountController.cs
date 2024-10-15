    using Inventory.Data.Models;
using KoalaInventoryManagement.ViewModels.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager , RoleManager<IdentityRole> roleManager)
        {
            _UserManager = userManager;
            _signInManager = signInManager;
		    _roleManager = roleManager;
		}

        #region SinUp
        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpViewModel input)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _UserManager.FindByEmailAsync(input.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "The email is already in use. Please choose a different email.");
                    return View(input);
                }
                var user = new ApplicationUser()
                {
                    UserName = input.Email.Split("@")[0],
                    Email = input.Email,
                    FirstName = input.FirstName,
                    LastName = input.LastName,
                    PhoneNumber = input.phoneNumber,
                };
                var result = await _UserManager.CreateAsync(user, input.Password);

                if (result.Succeeded)
                {
                    await _UserManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(input);
        }
        #endregion


        #region Login and Logout
        public IActionResult Login()
        {
            if(Request.Cookies.TryGetValue("RememberMeFunc",out string rememberMeValue))
            {
                var value = rememberMeValue.Split('|');
                if(value.Length == 2)
                {
                    ViewBag.RememberMeEmail = value[0];  
                    ViewBag.RememberMePassword = value[1];
				}
            }
			ViewBag.Roles = _roleManager.Roles.ToList();
			return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel input)
		{
			if (ModelState.IsValid)
			{
				var user = await _UserManager.FindByEmailAsync(input.Email);

				if (user is not null)
				{
					if (await _UserManager.CheckPasswordAsync(user, input.Password))
					{
						var result = await _signInManager.PasswordSignInAsync(user, input.Password, input.RememberMe, true);
						if (result.Succeeded)
						{
							var roles = await _UserManager.GetRolesAsync(user); // Get user roles
							var userRole = roles.FirstOrDefault(); // Assume one role for now
							if (userRole != null)
							{
								// Store the user role in session
								HttpContext.Session.SetString("UserRole", userRole);
							}

							if (input.RememberMe)
							{
								Response.Cookies.Append("RememberMeFunc", $"{input.Email}|{input.Password}",
									new CookieOptions
									{
										Expires = DateTimeOffset.Now.AddDays(30),
										HttpOnly = true,
										Secure = true,
										SameSite = SameSiteMode.None
									});
							}
							return RedirectToAction("Index", "Home");
						}
					}
				}
				else
				{
					ModelState.AddModelError("", "Incorrect Email or Password");
				}
			}
			return View(input);
		}



		public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            Response.Cookies.Delete("RememberMeFunc");
            return RedirectToAction(nameof(Login));
        }

        #endregion


        #region Forget Password
        public IActionResult ForgetPassword()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel input)
        {
            if (ModelState.IsValid)
            {
                var user = await _UserManager.FindByEmailAsync(input.Email);
                if (user is not null)
                {
                    var token = await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var url = Url.Action("ResetPassword", "Account", new { Email = input.Email, Token = token }, Request.Scheme);

                    var email = new Email
                    {
                        body = $"Please reset your password using the following link: <a href='{url}'>Reset Password</a>",
                        subject = "Reset Password",
                        To = input.Email
                    };

                    await EmailSettings.SendEmailAsync(email); // Await the async email send method

                    return RedirectToAction(nameof(CheckYourInbox));
                }
            }

            return View(input);
        }


        public IActionResult CheckYourInbox()
        {
            return View();
        }
        #endregion


        #region Reset Password
        public IActionResult ResetPassword(string Email, string Token)
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel input)
        {
            if (ModelState.IsValid)
            {
                var user = await _UserManager.FindByEmailAsync(input.Email);

                if (user is not null)
                {
                    var result = await _UserManager.ResetPasswordAsync(user, input.Token, input.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                }
            }
            return View(input);
        }

		#endregion


		#region Login as guest
		public async Task<IActionResult> LoginAsGuest(string selectedRole)
		{
			var guestEmail = "guest@example.com";
			var guestPassword = "Guest@123";  

			var user = await _UserManager.FindByEmailAsync(guestEmail);

			if (user != null)
			{
				var result = await _signInManager.PasswordSignInAsync(user, guestPassword, false, true);

				if (result.Succeeded)
				{
					if (!await _UserManager.IsInRoleAsync(user, selectedRole))
					{
						await _UserManager.AddToRoleAsync(user, selectedRole);
					}

					return RedirectToAction("Index", "Home"); 
				}
			}

			return RedirectToAction("Login");  
		}

		#endregion
	}
}
