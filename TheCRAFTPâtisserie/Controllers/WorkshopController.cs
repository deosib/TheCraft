using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheCRAFTPâtisserie.Controllers
{
    public class WorkshopController : Controller
    {
        public IActionResult Course1()
        {
            ViewData["Title"] = "Course";
            return View();
        }
    }
}