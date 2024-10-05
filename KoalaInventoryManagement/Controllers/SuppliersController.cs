using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels.Suppliers;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SuppliersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var suppliersDB = await _unitOfWork.Suppliers.GetAllAsync();
            var categoriesDB = await _unitOfWork.Categories.GetAllAsync();
            _unitOfWork.Dispose();

            SuppliersTotalViewModel viewModel = new SuppliersTotalViewModel
            {
                suppliers = suppliersDB.Select(supplier => new SupplierViewModel
                {
                    Id = supplier.Id,
                    Name = supplier.Name,
                    Phone_Number = supplier.Phone_Number,
                    Email_Address = supplier.Email_Address,
                    Rating = (byte?)(supplier.Rating * 10) ?? 0
                }).ToList(),

                categories = categoriesDB.Select(category => new CategoryViewModel
                {
                    Id=category.Id,
                    Name = category.Name
                }).ToList()
            };
            return View(viewModel);
        }

        public async Task<IActionResult> DeleteSupplier(int id)
        {
            await _unitOfWork.Suppliers.DeleteByIdAsync(id);
            await _unitOfWork.CompleteAsync();
            _unitOfWork.Dispose();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _unitOfWork.Categories.DeleteByIdAsync(id);
            await _unitOfWork.CompleteAsync();
            _unitOfWork.Dispose();
            return RedirectToAction("Index");
        }
    }
}
