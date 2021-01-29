using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SA51ADWebApp1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NSLine()
        {
            ViewData["Title"] = "NS Line";
            return View("Line");
        }

        public IActionResult EWLine()
        {
            ViewData["Title"] = "EW Line";
            return View("Line");
        }
        public IActionResult CCLine()
        {
            ViewData["Title"] = "CC Line";
            return View("Line");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
