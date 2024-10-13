﻿using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.Models;
using KoalaInventoryManagement.Services.Filteration;
using KoalaInventoryManagement.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace KoalaInventoryManagement.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductFilterService _productFilter;

        public InventoryController(IUnitOfWork unitOfWork, IProductFilterService productFilter)
        {
            _unitOfWork = unitOfWork;
            _productFilter = productFilter;
        }

        //[HttpGet]
        //public async Task<IActionResult>  Index(string searchString, string sortOrder, int pageNumber, string currentFilter)
        //{
        //    List<ProductViewModel> productsViewModel = new List<ProductViewModel>();
        //    List<Product> products
        //        = _unitOfWork?.Products?.GetAll(["Supplier", "Category", "WareHouseProducts"])?.ToList()
        //            ?? new List<Product>();
        //    List<WareHouse> wareHouses = _unitOfWork?.WareHouses?.GetAll()?.ToList() ?? new List<WareHouse>();

        //    foreach (Product p in products)
        //    {
        //        foreach (WareHouseProduct whp in p.WareHouseProducts)
        //        {
        //            productsViewModel.Add(new ProductViewModel()
        //            {
        //                Id = p.Id,
        //                Name = p.Name,
        //                Description = p.Description,
        //                Price = p.Price,
        //                Image = p.Image ?? [0],
        //                WareHouseID = whp?.WareHouseID ?? 0,
        //                WareHouseName = wareHouses?.Find(w => w.Id == whp?.WareHouseID)?.Name ?? string.Empty,
        //                CurrentStock = whp?.CurrentStock ?? 0,
        //                MintStock = whp?.MinStock ?? 0,
        //                MaxStock = whp?.MaxStock ?? 0,
        //                CategoryID = p?.CategoryId ?? 0,
        //                CategoryName = p?.Category?.Name ?? string.Empty,
        //                SupplierID = p?.SupplierId ?? 0,
        //                SupplierName = p?.Supplier?.Name ?? string.Empty,
        //            });
        //        }
        //    }



        //    return View(productsViewModel);
        //}
        [HttpGet]
        public async Task<IActionResult> Index(string searchString, string sortOrder, int pageNumber = 1, string currentFilter = null)
        {
            // Ensure pageNumber is at least 1
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }

            IQueryable<Product> productsQuery = _unitOfWork?.Products?.GetAll(new string[] { "Supplier", "Category", "WareHouseProducts.WareHouse" }) ?? Enumerable.Empty<Product>().AsQueryable();
            List<WareHouse> wareHouses =  _unitOfWork?.WareHouses?.GetAll().ToList() ?? new List<WareHouse>();

            // Apply filtering based on search string
            if (!string.IsNullOrEmpty(searchString))
            {
                productsQuery = productsQuery.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }

            // Check the total count before pagination
            var totalCount = await productsQuery.CountAsync();
            Console.WriteLine($"Total Count before pagination: {totalCount}"); // Debug log

            int pageSize = 10; // Set your desired page size
            var paginatedProducts = await PaginatedList<Product>.CreateAsync(productsQuery, pageNumber, pageSize);

            // Convert to ProductViewModel
            var productsViewModel = paginatedProducts.Items.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Image = p.Image,
                // Assuming you want to list all warehouse names associated with the product
                WareHouseNames = p.WareHouseProducts.Select(wp => wp.WareHouse.Name).ToList(), // Get all warehouse names
                CurrentStock = p.WareHouseProducts.Sum(wp => wp.CurrentStock), // Sum current stock from all warehouses
                MinStock = p.WareHouseProducts.Min(wp => wp.MinStock),
                MaxStock = p.WareHouseProducts.Max(wp => wp.MaxStock),
                CategoryID = p.CategoryId ?? 0,
                CategoryName = p.Category?.Name ?? string.Empty,
                SupplierID = p.SupplierId ?? 0,
                SupplierName = p.Supplier?.Name ?? string.Empty,
            }).ToList();

            // Create a PaginatedList<ProductViewModel>
            var paginatedViewModel = new PaginatedList<ProductViewModel>(productsViewModel, paginatedProducts.TotalItems, paginatedProducts.PageIndex, pageSize);
            ViewBag.WareHouses = wareHouses;
            return View(paginatedViewModel);
        }





        [HttpPost]
        public JsonResult GetFilteredProducts(int wareHouseID, int categoryID, int supplierID, string searchString, string showedProducts)
        {
            ViewBag.SelectedWareHouse = wareHouseID;
            ViewBag.SelectedCategory = categoryID;
            ViewBag.SelectedSupplier = supplierID;

            List<ProductViewModel> showedProductsNow = _productFilter?.FilterData(wareHouseID, 
                categoryID, supplierID, searchString, showedProducts) ?? new List<ProductViewModel>();

            return Json(showedProductsNow);
        }

        [HttpPost]
        public IActionResult AddProduct(Product newProduct, WareHouseProduct wareHouseProduct)
        {
            if(_unitOfWork?.Products?.Add(newProduct) ?? false)
            {
                _unitOfWork?.Complete();
                wareHouseProduct.ProductID = _unitOfWork?.Products?.GetAll()?.LastOrDefault()?.Id ?? 0;

                if(_unitOfWork?.WareHousesProducts?.Add(wareHouseProduct) ?? false)
                    _unitOfWork?.Complete();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            if(_unitOfWork?.Products?.Delete(id) ?? false)
                _unitOfWork?.Complete();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product editedProduct, WareHouseProduct editedWHP, int oldWareHouseID)
        {
            if(editedProduct != null && editedWHP != null && oldWareHouseID > 0)
            {
                Product? existingProduct = _unitOfWork?.Products?.GetbyId(editedProduct.Id);
                if (existingProduct != null)
                {
                    if (_unitOfWork?.Products?.Update(editedProduct) ?? false)
                        _unitOfWork?.Complete();

                    WareHouseProduct? existingWHP
                        = _unitOfWork?.WareHousesProducts?.GetWareHouseProduct(existingProduct.Id, oldWareHouseID);

                    if (existingWHP != null)
                    {
                        if (_unitOfWork?.WareHousesProducts?.DeleteOneRecord(editedProduct.Id, oldWareHouseID) ?? false)
                        {
                            _unitOfWork?.Complete();
                            editedWHP.ProductID = editedProduct.Id;
                            if (_unitOfWork?.WareHousesProducts?.Add(editedWHP) ?? false)
                                _unitOfWork?.Complete();
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ShowDetails(int id)
        {
            Product? product
                = _unitOfWork?.Products?.GetbyId(id, ["Supplier", "Category"]) ?? new Product();

            List<WareHouseProduct> prdWareHouses
                = _unitOfWork?.WareHousesProducts?
                              .GettWareHousesProductsByPrdID(id, ["WareHouse"])?
                              .ToList() ?? new List<WareHouseProduct>();


            int productQuantity = 0;
            foreach(int currentStock in prdWareHouses.Select(whp => whp.CurrentStock))
                productQuantity += currentStock;

            ProductDetailsVM productDetails = new ProductDetailsVM()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image ?? [0],
                Quantity = productQuantity,
                ProductWareHouses = prdWareHouses,
                CategoryName = product?.Category?.Name ?? string.Empty,
                SupplierName = product?.Supplier?.Name ?? string.Empty,
            };

            return View(productDetails);
        }
    }
}
