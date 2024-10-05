using Inventory.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allproducts = _unitOfWork.Products.GetAll();
            return Ok(allproducts) ;
        }
        [HttpGet]
        public IActionResult Getview()
        {
            
            return View("index");
        }

        [HttpGet]
        public IActionResult Search()
        {
            var searchTerm = "Palestine Flag".ToLower(); // Convert the search term to lowercase
            var ProductName = _unitOfWork.Products.FindByName(
                a => a.Name.ToLower().Contains(searchTerm),
                null
            );
            return Ok(ProductName);
        }

        [HttpPost]
        public IActionResult AddNewProduct()
        {
            var addNewProduct = _unitOfWork.Products.Add(new Models.Product{  Name = "Test", Description = "Flags Test", Price = 20, CreateAt = DateTime.Now });
           _unitOfWork.Complete();  
            return Ok(addNewProduct);
        }

        [HttpGet]
        public IActionResult DeleteProduct()
        {
            var DeleteProduct = _unitOfWork.Products.Delete(1);
            _unitOfWork.Complete();
            return Ok(_unitOfWork.Products.GetAll());
        }

        [HttpPost]
        public IActionResult UpdateProduct()
        {
            var UpdateProduct = _unitOfWork.Products.Update(new Models.Product { Id = 5, Name = "salama2", Description = "Test salama2", Price = 50});
            _unitOfWork.Complete();
            return Ok(UpdateProduct);
        }

        [HttpGet]
        public IActionResult GetAllProductSupplier()
        {
            var products= _unitOfWork.Products.GetProductsBySupplier(1);
            return Ok(products);
        }
        [HttpGet]
        public IActionResult GetAllProductCategory()
        {
            var products = _unitOfWork.Products.GetProductsByCategory(1);
            return Ok(products);
        }
    }
}
