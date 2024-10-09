using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Data.Models;
using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KoalaInventoryManagement.Controllers
{
    [Route("[controller]")]
    public class SalesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Create(Sales sales)
        {
            if (ModelState.IsValid)
            {
                // var product = _InventoryDbContext.Products.Find(sales.Id);
                // if (product != null && product.CurrentStock >= sales.ItemsBought)
                // {
                //     product.CurrentStock -= sales.ItemsBought; // Reduce stock
                //     sales.TotalProfit = (decimal)product.Price * sales.ItemsBought; // Calculate total profit
                //     _unitOfWork.Sales.AddAsync(sales);
                //     _InventoryDbContext.SaveChanges();
                //     return RedirectToAction("Index");
                // }
            }
            return View(sales);
        }
        public IActionResult Index()
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