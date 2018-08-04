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
            ViewData["Title"] = "The Craft";
            return View();
        }

        public IActionResult Menu()
        {
            ViewData["Title"] = "Menu";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }

        public IActionResult Workshop()
        {
            ViewData["Title"] = "Workshop";
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
    }
}
