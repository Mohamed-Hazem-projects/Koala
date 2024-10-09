using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using KoalaInventoryManagement.ViewModels.Sales;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KoalaInventoryManagement.Controllers
{
    public class SalesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var sales = _unitOfWork.Sales.GetAll(["Product"]);
            var salesVM = new List<SalesViewModel>();
            foreach (var sale in sales)
            {
                salesVM.Add(new SalesViewModel
                {
                    Id = sale.Id,
                    ItemsSold = sale.ItemsSold,
                    SaleDate = sale.SaleDate,
                    TotalPrice = sale.TotalPrice,
                    ProductId = sale.ProductId,
                    ProductName = sale.Product.Name
                });
            }
            return View(salesVM);
        }

        public IActionResult Form()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}