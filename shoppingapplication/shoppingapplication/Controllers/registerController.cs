using Microsoft.AspNetCore.Mvc;
using shoppingapplication.Models;
using shoppingapplication.Services;
namespace shoppingapplication.Controllers
{
    public class registerController : Controller
    {
        private readonly IRegisterService _registerService; 
        public registerController(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult InsertDetails(loginmodel lmodel)
        {
            int recordsCount = _registerService.ServiceInsertUser(lmodel);
            if (recordsCount > 0)
            {
                ViewBag.Result = "Data saved successfully";
            }
            return RedirectToAction("Index","login");
        }

    }
}
