using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(/*string username,string password*/   LoginViewModel model)
        {

            //string username = Request.Query["Username"];
            //string password = Request.Query["Password"];
            if (model.Username == "a@a" && model.Password=="123")
            {
                return Content("Login Successfully ");
            }
               return Content("Username or password not correct ");
        }
    }
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}