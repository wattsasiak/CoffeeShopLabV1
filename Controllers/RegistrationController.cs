using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopVersion1.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Welcome(string firstname, string lastname)
        {


            ViewData["FirstName"] = firstname;
            ViewData["LastName"] = lastname;
            return View();
        }


        public IActionResult Registration()
        {
            return View();
        }
    }
}
