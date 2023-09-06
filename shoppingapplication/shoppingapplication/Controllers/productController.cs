using Microsoft.AspNetCore.Mvc;

namespace shoppingapplication.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
