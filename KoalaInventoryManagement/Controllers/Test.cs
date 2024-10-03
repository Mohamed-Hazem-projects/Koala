using Inventory.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class Test : Controller
    {
        private readonly ICategoryService _catservice;
        public Test(ICategoryService catservice)
        {
            _catservice = catservice;
        }
        public IActionResult Index(int Id)
        {
            return Ok(_catservice.GetbyId(Id));
        }
    }
}
