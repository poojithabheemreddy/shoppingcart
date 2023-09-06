using Microsoft.AspNetCore.Mvc;
using shoppingapplication.Services;
namespace shoppingapplication.Controllers
{
    public class categoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public categoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertCategory(int categoryName, string categoryDesc)
        {
            int recordsCount=_categoryService.ServiceInsertCategory(categoryName, categoryDesc);
            if (recordsCount > 0)
            {
                ViewBag.Result = "Data saved successfully";
            }
            return RedirectToAction("Index", "category");
        }
    }
}
