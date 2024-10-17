using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.ViewModels.Dashboard;
using KoalaInventoryManagement.ViewModels.Products;
using KoalaInventoryManagement.ViewModels.Suppliers;
using KoalaInventoryManagement.ViewModels.Warehouse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public WarehouseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var warehousesDb = _unitOfWork.WareHouses.GetAll();
            WarehouseWithProductsViewModel viewModel = new WarehouseWithProductsViewModel
            {
                warehouse = warehousesDb.Select(wareHouse => new WarehouseViewModel
                {
                    Id = wareHouse.Id,
                    Name = wareHouse.Name,
                }).ToList(),

             
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(WareHouse wareHouse)
        {


            var warehouses = _unitOfWork.WareHouses.Add(wareHouse);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(WareHouse wareHouse)
        {
            var warehouses = _unitOfWork.WareHouses.Update(wareHouse);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {


            var warehouses = _unitOfWork.WareHouses.Delete(id);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        public IActionResult ShowWarehouseDetails(int id)
        {
          
          
            var warehouse = _unitOfWork.WareHouses.GetbyId(id, new[] { "WareHouseProducts.Product" });
            
            
            var viewModel = new WarehouseWithProductsViewModel
            {
                
                Products = warehouse.WareHouseProducts.Select(wp => new ProductViewModel
                {
                    Id = wp.ProductID,
                    Name = wp.Product.Name,
                    Description = wp.Product.Description,
                    Price = wp.Product.Price,
                    MintStock = wp.MinStock,
                    CurrentStock = wp.CurrentStock,
                    MaxStock = wp.MaxStock,
                   
                }).ToList()
            };

            // Pass the warehouse view model to the view
            return View("details", viewModel );
           
        }

    }
}
