using Microsoft.AspNetCore.Mvc;
using shoppingapplication.Models;
using shoppingapplication.Services;
using System.Text.Json;

namespace shoppingapplication.Controllers
{
    public class loginController : Controller
    {
        private readonly ILoginService _loginservice;
        public loginController(ILoginService loginservice) 
        { 
            _loginservice = loginservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetDetails(string username,string password)
        {
            loginmodel lmodel=new loginmodel();
            lmodel.useracc_uname=username;   
            lmodel.useracc_password=password;
            var userdetails = _loginservice.ServiceGetUserDetails(lmodel);
            if (userdetails != null)
            {
               return Json("OK");
            }
            else
            {
                ViewBag.Result = "User not found";
                return Json("OK");
            }         
            
        }
    }
}
