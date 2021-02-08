using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Service;
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
        protected IAdminService adminService;
        protected IStationOnLineService solService;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService, IStationOnLineService solService)
        {
            _logger = logger;
            this.adminService = adminService;
            this.solService = solService;
        }
        public IActionResult Dashboard()
        {
            List<StationOnLine> nonOperationalLines = solService.getAllNonOperational();
            ViewBag.faultyLines = nonOperationalLines;
            return View();
        }

        public IActionResult NSLine()
        {
            ViewData["Title"] = "NS Line";
            ViewBag.LineCode = "NS";
            List<StationOnLine> stationOnLineList = solService.getAllStationsOnLine("North-South Line");
            ViewBag.Line = stationOnLineList;
            return View("Line");
        }

        public IActionResult EWLine()
        {
            ViewData["Title"] = "EW Line";
            ViewBag.LineCode = "EW";
            List<StationOnLine> stationOnLineList = solService.getAllStationsOnLine("East-West Line");
            ViewBag.Line = stationOnLineList;
            return View("Line");
        }
        public IActionResult CCLine()
        {
            ViewData["Title"] = "CC Line";
            ViewBag.LineCode = "CC";
            List<StationOnLine> stationOnLineList = solService.getAllStationsOnLine("Circle Line");
            ViewBag.Line = stationOnLineList;
            return View("Line");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Edit(String stationCode)
        {
            StationOnLine specificStation = solService.getSpecificStationOnLine(stationCode);
            return View(specificStation);
        }
        [HttpPost]
        public IActionResult Edit(StationOnLine sol)
        {
            solService.saveEdit(sol);
            TempData["Success"] = "Added Successfully!";
            if (sol.LineId == 3)
            {
                return RedirectToAction("CCLine");
            }
            else if (sol.LineId == 1)
            {
                return RedirectToAction("EWLine");
            }
            else if (sol.LineId == 2)
            {
                return RedirectToAction("NSLine");
            }
            else
            {
                return RedirectToAction("Dashboard");
            }
        }
        public IActionResult Cancel(int lineID)
        {
            if (lineID == 3)
            {
                return RedirectToAction("CCLine");
            }
            else if (lineID == 1)
            {
                return RedirectToAction("EWLine");
            }
            else if (lineID == 2)
            {
                return RedirectToAction("NSLine");
            }
            else
            {
                return RedirectToAction("Dashboard");
            }
        }
    }
}
