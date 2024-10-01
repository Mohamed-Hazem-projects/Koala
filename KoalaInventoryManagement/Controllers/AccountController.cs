using Invetory.Data.Entities;
using Invetory.web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Invetory.Servics.Helper;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Invetory.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager  )
        {
            _UserManager = userManager;
            _signInManager = signInManager;
        }

        #region SinUp
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel input)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = input.Email.Split("@")[0],
                    Email = input.Email,
                    FirstName = input.FirstName,
                    LastName = input.LastName
                };
                var result = await _UserManager.CreateAsync(user, input.Password);

                if (result.Succeeded)
                {
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
            return View();
        }

        [HttpPost]
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
                            if (input.RememberMe)
                            {
                                Response.Cookies.Append("RememberMeFunc" , $"{input.Email}|{input.Password}",
                                    new CookieOptions
                                    {
                                        Expires = DateTime.Now.AddDays(30),
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
                    ModelState.AddModelError("", " Incorrect Email or Password");
                }
            }
            return View(input);
        }

        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Clear();
            await _signInManager.SignOutAsync();
            Response.Cookies.Delete("RememberMeFunc");
            return RedirectToAction(nameof(Login));
        }

        #endregion


  //      #region Forget Password
  //      public IActionResult ForgetPassword()
  //      {
  //          return View();
  //      }

  //      [HttpPost]
  //      public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel input)
  //      {
  //          if (ModelState.IsValid)
  //          {
  //              var user = await _UserManager.FindByEmailAsync(input.Email);
  //              if (user is not null)
  //              {
  //                  var token = await _UserManager.GeneratePasswordResetTokenAsync(user);
  //                  var url = Url.Action("ResetPassword", "Account", new { Email = input.Email, Token = token },Request.Scheme);
  //                  var email = new Email
  //                  {
  //                      body = url,
  //                      subject = "Reset Password",
  //                      To = input.Email
  //                  };
  //                  EmailSettings.SendEmail(email);
  //                  return RedirectToAction(nameof(CheckYourInbox));
  //              }
  //          }
  //          return View(input);
  //      }

  //      public IActionResult CheckYourInbox()
  //      {
  //          return View();
  //      }
  //      #endregion


  //      #region Reset Password
  //      public IActionResult ResetPassword(string Email, string Token)
  //      {
  //          return View();
  //      }

  //      [HttpPost]
  //      public async Task<IActionResult> ResetPassword(ResetPasswordViewModel input)
  //      {
  //          if (ModelState.IsValid)
  //          {
  //              var user = await _UserManager.FindByEmailAsync(input.Email);

  //              if (user is not null)
  //              {
  //                  var result = await _UserManager.ResetPasswordAsync(user, input.Token, input.Password);
  //                  if (result.Succeeded)
  //                  {
  //                      return RedirectToAction("Login");
  //                  }
  //              }
  //          }
  //          return View(input);
  //      }

  //      #endregion


  //      #region Access Denied page
  //      public IActionResult AccessDenied()
  //      {
  //          return View();
  //      }
  //      #endregion


  //      #region Facebokk Login

  //      [HttpGet]
		//public IActionResult ExternalLogin(string provider)
		//{
		//	var redirectUrl = Url.Action("ExternalLoginCallback", "Account");
		//	var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
		//	properties.IsPersistent = true;
		//	return Challenge(properties, provider);
		//}

		//[HttpGet]
		//public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
		//{
		//	var info = await _signInManager.GetExternalLoginInfoAsync();
		//	if (info == null)
		//	{
		//		return RedirectToAction(nameof(Login));
		//	}

		//	// Retrieve user email from the external login provider (Facebook)
		//	var email = info.Principal.FindFirstValue(ClaimTypes.Email);

		//	// Check if the user already exists in your database
		//	var user = await _UserManager.FindByEmailAsync(email);
		//	if (user == null)
		//	{
		//		// New user, create and save it in your Identity DB
		//		user = new ApplicationUser
		//		{
		//			UserName = email,
		//			Email = email,
		//			FirstName = info.Principal.FindFirstValue(ClaimTypes.GivenName),
		//			LastName = info.Principal.FindFirstValue(ClaimTypes.Surname)
		//		};

		//		var createResult = await _UserManager.CreateAsync(user);
		//		if (!createResult.Succeeded)
		//		{
		//			foreach (var error in createResult.Errors)
		//			{
		//				ModelState.AddModelError(string.Empty, error.Description);
		//			}
		//			return RedirectToAction(nameof(Login));
		//		}

		//		// Add external login info to the user
		//		var loginResult = await _UserManager.AddLoginAsync(user, info);
		//		if (!loginResult.Succeeded)
		//		{
		//			ModelState.AddModelError(string.Empty, "Could not link external login.");
		//			return RedirectToAction(nameof(Login));
		//		}

		//		// Sign in the user
		//		await _signInManager.SignInAsync(user, isPersistent: false);
		//	}
		//	else
		//	{
  //              // Existing user, sign them in
  //              var loginResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
  //              if (!loginResult.Succeeded)
  //              {
  //                  // If the login fails, but the user exists, sign in normally
  //                  await _signInManager.SignInAsync(user, isPersistent: false);
  //              }
  //          }

		//	return RedirectToLocal(returnUrl);
		//}

		//private IActionResult RedirectToLocal(string returnUrl)
		//{
		//	if (Url.IsLocalUrl(returnUrl))
		//	{
		//		return Redirect(returnUrl);
		//	}
		//	return RedirectToAction("Index", "Home");
		//}
  //      #endregion


    }
}
