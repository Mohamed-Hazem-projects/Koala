using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;
using System.Data;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController : Controller
    {
        public UserManager<ApplicationUser> _UserManager;
        public RoleManager<IdentityRole> _RoleManager;
        private readonly IUnitOfWork _unitOfWork;
        public AdminDashboardController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager , RoleManager<IdentityRole> roleManager)
        {
            _UserManager = userManager;
            _RoleManager = roleManager;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _UserManager.Users.ToListAsync(); 
            var roles = await _RoleManager.Roles.ToListAsync();
            var warehouses = _unitOfWork.WareHouses.GetAll(); // Use Unit of Work to fetch warehouses

            var userRolesViewModel = new List<UserRolesViewModel>();

            foreach (var user in users)
            {
                if (user.FirstName.Equals("guest", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                var userRoles = await _UserManager.GetRolesAsync(user);
                var assignedWarehouse = _unitOfWork.WareHousesProducts.GetUserWarehouse(user.Id);
                userRolesViewModel.Add(new UserRolesViewModel
                {
                    UserId = user.Id,
                    FullName = $"{user.FirstName} {user.LastName}",
                    Roles = userRoles.ToList(),
                    Warehouses = warehouses, // Add warehouses to the ViewModel
                    AssignedWarehouseId = assignedWarehouse?.WarehouseId ?? 0
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

        public async Task<IActionResult> UpdateUserRoles(string userId, List<string> Roles, int warehouseId)
        {
            var appUser = await _UserManager.FindByIdAsync(userId);
            if (appUser == null)
            {
                return NotFound();
            }

            // Remove existing roles
            var currentRoles = await _UserManager.GetRolesAsync(appUser);
            var rolesToRemove = currentRoles.Except(Roles); // Roles to remove
            var rolesToAdd = Roles.Except(currentRoles); // Roles to add

            foreach (var currentRole in rolesToRemove)
            {
                await _UserManager.RemoveFromRoleAsync(appUser, currentRole);
            }

            foreach (var newRole in rolesToAdd)
            {
                if (!string.IsNullOrWhiteSpace(newRole))
                {
                    await _UserManager.AddToRoleAsync(appUser, newRole);
                }
            }


            // Update the user-warehouse mapping
            var existingUserWarehouse = _unitOfWork.WareHousesProducts.GetUserWarehouse(userId);

            if (existingUserWarehouse != null)
            {
                // If the user-warehouse mapping exists, update it with the new warehouseId
                existingUserWarehouse.WarehouseId = warehouseId;
                _unitOfWork.WareHousesProducts.UpdateWHUser(existingUserWarehouse);
            }
            else
            {
                // If no existing mapping is found, create a new one
                var userWarehouse = new UserWarehouse
                {
                    UserId = userId,
                    WarehouseId = warehouseId
                };
                _unitOfWork.WareHousesProducts.AddWHUser(userWarehouse);
            }

            // Save changes to the database
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }



    }
}
