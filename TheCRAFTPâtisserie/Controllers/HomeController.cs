using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCRAFTPâtisserie.Models;

namespace TheCRAFTPâtisserie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Workshop()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
    }
}
