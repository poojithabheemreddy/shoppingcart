using Microsoft.AspNetCore.Mvc;

namespace shoppingapplication.Controllers
{
    public class searchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
