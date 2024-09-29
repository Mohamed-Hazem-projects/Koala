using Microsoft.AspNetCore.Mvc;

namespace KoalaInventoryManagement.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            //We need number of products,Number of sales,Total profit
            //we need api calls for the charts to send data by ajax calls
            //in dashboard.js
            return View();
        }
    }
}
