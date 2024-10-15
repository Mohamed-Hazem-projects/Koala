using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels.Suppliers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    [Authorize(Roles = "Admin,WHManager1,WHManager2,WHManager3,WHManager4,WHManager5")]
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

        [HttpPost]
        public async Task<IActionResult> AddSupplier(Supplier supplier)
        {
            //m7tag a3ml el parameter Supplier m3 en da 8lt 3shan mfi4 service layer
            await _unitOfWork.Suppliers.AddAsync(supplier);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSupplier(Supplier supplier)
        {
            //m7tag a3ml el parameter Supplier m3 en da 8lt 3shan mfi4 service layer
            await _unitOfWork.Suppliers.UpdateAsync(supplier);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            await _unitOfWork.Suppliers.DeleteByIdAsync(id);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            //m7tag a3ml el parameter Category m3 en da 8lt 3shan mfi4 service layer
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            //m7tag a3ml el parameter Category m3 en da 8lt 3shan mfi4 service layer
            await _unitOfWork.Categories.UpdateAsync(category);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _unitOfWork.Categories.DeleteByIdAsync(id);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }
    }
}
