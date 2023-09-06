using Microsoft.AspNetCore.Mvc;

namespace shoppingapplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
