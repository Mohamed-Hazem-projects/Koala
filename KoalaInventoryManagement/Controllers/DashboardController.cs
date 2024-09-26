using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            //We need number of products,Number of sales,Total profit
            return View();
        }
    }
}
