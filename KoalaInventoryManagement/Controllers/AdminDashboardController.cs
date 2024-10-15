using Inventory.Data.Models;
using KoalaInventoryManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController : Controller
    {
        public UserManager<ApplicationUser> _UserManager;
        public RoleManager<IdentityRole> _RoleManager;
        public AdminDashboardController(UserManager<ApplicationUser> userManager , RoleManager<IdentityRole> roleManager)
        {
            _UserManager = userManager;
            _RoleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _UserManager.Users.ToListAsync();
            var roles = await _RoleManager.Roles.ToListAsync(); 
            var userRolesViewModel = new List<UserRolesViewModel>();

            foreach (var user in users)
            {
				if (user.FirstName.Equals("guest", StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				var userRoles = await _UserManager.GetRolesAsync(user);
                userRolesViewModel.Add(new UserRolesViewModel
                {
                    UserId = user.Id,
                    FullName = $"{user.FirstName} {user.LastName}",
                    Roles = userRoles.ToList() 
                });
            }

            ViewBag.Roles = roles;
            return View(userRolesViewModel); 
        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var user = await _UserManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                var result = await _UserManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }
            
        public async Task<IActionResult> UserDetails(string Id)
        {
            var user = await _UserManager.FindByIdAsync(Id);

            if (user == null)
            {
                return NotFound();
            }
            var userRoles = await _UserManager.GetRolesAsync(user);

            var userDetailsViewModel = new UserDetailsViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                phoneNumber = user.PhoneNumber,
                roles = userRoles.ToList()
            };

            return View(userDetailsViewModel);
        }

        public async Task<IActionResult> UpdateUserRoles(string userId, List<string> Roles)
        {
            var appUser = await _UserManager.FindByIdAsync(userId);
            if (appUser == null)
            {
                return NotFound();
            }

            var currentRoles = await _UserManager.GetRolesAsync(appUser);

            foreach (var role in Roles)
            {
                if (!await _UserManager.IsInRoleAsync(appUser, role))
                {
                    var result = await _UserManager.AddToRoleAsync(appUser, role);
                    if (!result.Succeeded)
                    {
                        return BadRequest($"Failed to add role {role} to user {appUser.UserName}");
                    }
                }
            }

            foreach (var role in currentRoles)
            {
                if (!Roles.Contains(role))
                {
                    var result = await _UserManager.RemoveFromRoleAsync(appUser, role);
                    if (!result.Succeeded)
                    {
                        return BadRequest($"Failed to remove role {role} from user {appUser.UserName}");
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}
