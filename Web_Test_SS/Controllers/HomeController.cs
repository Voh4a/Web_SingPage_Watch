using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Test_SS.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}