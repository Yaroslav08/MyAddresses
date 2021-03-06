using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAddresses.MVC.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet("Index")]
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
