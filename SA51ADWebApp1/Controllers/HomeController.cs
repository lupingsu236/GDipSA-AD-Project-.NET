using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SA51ADWebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected IAdminService adminService;
        protected IStationOnLineService solService;
        protected ITransactionService transService;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService, IStationOnLineService solService, ITransactionService transService)
        {
            _logger = logger;
            this.adminService = adminService;
            this.solService = solService;
            this.transService = transService;
        }
        public IActionResult Dashboard()
        {
            ViewData["Title"] = "Dashboard";
            List<StationOnLine> nonOperationalLines = solService.getAllNonOperational();
            ViewBag.faultyLines = nonOperationalLines;
            return View();
        }

        public IActionResult NSLine()
        {
            ViewData["Title"] = "NS Line";
            ViewData["Header"] = "North-South Line";
            ViewBag.LineCode = "NS";
            List<StationOnLine> stationOnLineList = solService.getAllStationsOnLine("North-South Line");
            ViewBag.Line = stationOnLineList;
            return View("Line");
        }

        public IActionResult EWLine()
        {
            ViewData["Title"] = "EW Line";
            ViewData["Header"] = "East-West Line";
            ViewBag.LineCode = "EW";
            List<StationOnLine> stationOnLineList = solService.getAllStationsOnLine("East-West Line");
            ViewBag.Line = stationOnLineList;
            return View("Line");
        }
        public IActionResult CCLine()
        {
            ViewData["Title"] = "CC Line";
            ViewData["Header"] = "Circle Line";
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
            ViewData["Title"] = "Edit";
            StationOnLine specificStation = solService.getSpecificStationOnLine(stationCode);
            ViewBag.transactions = (List<Transaction>) transService.getAllTransactionsAtStation(specificStation);
            return View(specificStation);
        }

        [HttpPost]
        public IActionResult Edit(StationOnLine sol)
        {
            if (!ModelState.IsValid)
            {
                StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                sol.Station = specificStation.Station;
                ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                return View(sol);
            }
            if (sol.status == Status.DelayBoth)
            {
                if (sol.editedTimeToNextStation <= sol.timeToNextStation || sol.editedTimeToNextStationOpp <= sol.timeToNextStationOpp)
                {
                    if (sol.editedTimeToNextStation <= sol.timeToNextStation)
                    {
                        ViewBag.timingErrorForward = "Please enter a valid value greater than the default time of " + sol.timeToNextStation + " minutes";
                    }
                    if (sol.editedTimeToNextStationOpp <= sol.timeToNextStationOpp)
                    {
                        ViewBag.timingErrorOpp = "Please enter a valid value greater than the default time of " + sol.timeToNextStationOpp + " minutes";
                    }
                    StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                    sol.Station = specificStation.Station;
                    ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                    return View(sol);
                }
            }
            if (sol.status == Status.DelayOpposite)
            {
                if (sol.editedTimeToNextStation <= sol.timeToNextStation)
                {
                    ViewBag.timingErrorForward = "Please enter a valid value greater than the default time of " + sol.timeToNextStation + " minutes";
                    StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                    sol.Station = specificStation.Station;
                    ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                    return View(sol);
                }
            }
            if (sol.status == Status.DelayForward)
            {
                if (sol.editedTimeToNextStationOpp <= sol.timeToNextStationOpp)
                {
                    ViewBag.timingErrorOpp = "Please enter a valid value greater than the default time of " + sol.timeToNextStationOpp + " minutes";
                    StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                    sol.Station = specificStation.Station;
                    ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                    return View(sol);
                }
            }
            if (sol.editedTimeToNextStation < sol.timeToNextStation || sol.editedTimeToNextStationOpp < sol.timeToNextStationOpp)
            {
                StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                sol.Station = specificStation.Station;
                ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                if (sol.editedTimeToNextStation < sol.timeToNextStation)
                {
                    ViewBag.timingErrorForward = "Please enter a valid value not less than the default time of " + sol.timeToNextStation + " minutes";
                }
                if (sol.editedTimeToNextStationOpp < sol.timeToNextStationOpp)
                {
                    ViewBag.timingErrorOpp = "Please enter a valid value not less than the default time of " + sol.timeToNextStationOpp + " minutes";
                }
                return View(sol);
            }
            if (sol.status == Status.BreakdownBoth)
            {
                sol.editedTimeToNextStation = 2000000000;
                sol.editedTimeToNextStationOpp = 2000000000;
            }
            else if (sol.status == Status.BreakdownOpposite)
            {
                sol.editedTimeToNextStation = 2000000000;
            }
            else if (sol.status == Status.BreakdownForward)
            {
                sol.editedTimeToNextStationOpp = 2000000000;
            }
            string userIdString = Request.Cookies["sessionId"];
            int userId = Convert.ToInt32(userIdString);
            transService.saveTransaction(sol, userId);
            solService.saveEdit(sol);
            TempData["Success"] = "Added Successfully!";

            List<string> notificationContent = solService.GenerateNotificationMsg(sol);
            string title = notificationContent[0];
            string body = notificationContent[1];
            var push = NotificationService.PushNotification.Send(title, body);

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
