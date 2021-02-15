﻿using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

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
            ViewBag.transactions = (List<Transaction>) transService.getAllTransactionsAtStation(specificStation);
            return View(specificStation);
        }
        //[HttpPost]
        //public IActionResult Edit(StationOnLine sol)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
        //        sol.Station = specificStation.Station;
        //        ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
        //        return View(sol);
        //    }
        //    string userIdString = Request.Cookies["sessionId"];
        //    int userId = Convert.ToInt32(userIdString);
        //    transService.saveTransaction(sol, userId);
        //    solService.saveEdit(sol);
        //    TempData["Success"] = "Added Successfully!";

        //    string stationname = solService.getSpecificStationName(sol.stationCode);
        //    string title = "MRT4You";
        //    string body = "";
        //    if (sol.status == Status.BreakdownBoth)
        //    {
        //        body = sol.stationCode + " " + stationname + " both directions break down.";
        //    }
        //    else if (sol.status == Status.BreakdownForward)
        //    {
        //        body = sol.stationCode + " " + stationname + " forward direction breaks down.";
        //    }
        //    else if (sol.status == Status.BreakdownOpposite)
        //    {
        //        body = sol.stationCode + " " + stationname + " opposite direction breaks down.";
        //    }
        //    else if (sol.status == Status.DelayBoth)
        //    {
        //        body = sol.stationCode + " " + stationname + " both directions delay." +
        //            " time to next forward station is expected to be " + sol.editedTimeToNextStation +
        //            " min, time to next opposite station is expected to be " + sol.editedTimeToNextStationOpp + " min";
        //    }
        //    else if (sol.status == Status.DelayForward)
        //    {
        //        body = sol.stationCode + " " + stationname + " forward direction delays." +
        //            " time to next forward station is expected to be " + sol.editedTimeToNextStation + " min";
        //    }
        //    else if (sol.status == Status.DelayOpposite)
        //    {
        //        body = sol.stationCode + " " + stationname + " opposite direction delays." +
        //            " time to next opposite station is expected to be " + sol.editedTimeToNextStationOpp + " min";
        //    }
        //    else
        //    {
        //        body = sol.stationCode + " " + stationname + " returns to be operational.";
        //    }
        //    var data = new { action = "Play", userId = 20 };
        //    var tokens = new string[2] {"c0J6EgUOQf6pGOlfAgllAL:APA91bGl9xlBE7H5lKsz8wn3VebZ1tuGZGVUSoLvzGPcln8TdmibNA-uAOq-OJ8VwQJR0TcgQKex_vXzqo67lcVTDz2Wunchsu7KLMjNxTxrCK93GHbhhpBAbK66AwSrXjnKd_oiy4ej",
        //                                "eGcvE4FYQH614rWtXeGCEy:APA91bEAEebP2PPzdFtmqa1F9n-yW3uAygNOCvXedUjDyj38txKn26Gh1yq6xviT5MQShizY5vJkIiekvAGLyEuBW2DVM9C09lmLANns7dF1_yNcY1s-sA6n3PC3TMK8TkEBjiXpVrXG"};
        //    var pushSent = NotificationService.pushNotification.SendPushNotification(tokens, title, body, data);

        //    if (sol.LineId == 3)
        //    {
        //        return RedirectToAction("CCLine");
        //    }
        //    else if (sol.LineId == 1)
        //    {
        //        return RedirectToAction("EWLine");
        //    }
        //    else if (sol.LineId == 2)
        //    {
        //        return RedirectToAction("NSLine");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Dashboard");
        //    }
        //}

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
               if(sol.editedTimeToNextStation <= sol.timeToNextStation || sol.editedTimeToNextStationOpp <= sol.timeToNextStationOpp)
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
            if (sol.status == Status.DelayForward)
            {
                if(sol.editedTimeToNextStation <= sol.timeToNextStation)
                {
                    ViewBag.timingErrorForward = "Please enter a valid value greater than the default time of " + sol.timeToNextStation + " minutes";
                    StationOnLine specificStation = solService.getSpecificStationOnLine(sol.stationCode);
                    sol.Station = specificStation.Station;
                    ViewBag.transactions = (List<Transaction>)transService.getAllTransactionsAtStation(specificStation);
                    return View(sol);
                }
            }
            if (sol.status == Status.DelayOpposite)
            {
                if(sol.editedTimeToNextStationOpp <= sol.timeToNextStationOpp)
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
                if(sol.editedTimeToNextStation < sol.timeToNextStation)
                {
                    ViewBag.timingErrorForward = "Please enter a valid value not less than the default time of " + sol.timeToNextStation + " minutes";
                }
                if(sol.editedTimeToNextStationOpp < sol.timeToNextStationOpp)
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
            else if (sol.status == Status.BreakdownForward)
            {
                sol.editedTimeToNextStation = 2000000000;
            }
            else if (sol.status == Status.BreakdownOpposite)
            {
                sol.editedTimeToNextStationOpp = 2000000000;
            }
            string userIdString = Request.Cookies["sessionId"];
            int userId = Convert.ToInt32(userIdString);
            transService.saveTransaction(sol, userId);
            solService.saveEdit(sol);
            TempData["Success"] = "Added Successfully!";

            string stationname = solService.getSpecificStationName(sol.stationCode);
            string title = "MRT4You";
            string body;
            if (sol.status == Status.BreakdownBoth)
            {
                body = sol.stationCode + " " + stationname + " both directions break down.";
            }
            else if (sol.status == Status.BreakdownForward)
            {
                body = sol.stationCode + " " + stationname + " forward direction breaks down.";
            }
            else if (sol.status == Status.BreakdownOpposite)
            {
                body = sol.stationCode + " " + stationname + " opposite direction breaks down.";
            }
            else if (sol.status == Status.DelayBoth)
            {
                body = sol.stationCode + " " + stationname + " both directions delay." +
                    " time to next forward station is expected to be " + sol.editedTimeToNextStation +
                    " min, time to next opposite station is expected to be " + sol.editedTimeToNextStationOpp + " min";
            }
            else if (sol.status == Status.DelayForward)
            {
                body = sol.stationCode + " " + stationname + " forward direction delays." +
                    " time to next forward station is expected to be " + sol.editedTimeToNextStation + " min";
            }
            else if (sol.status == Status.DelayOpposite)
            {
                body = sol.stationCode + " " + stationname + " opposite direction delays." +
                    " time to next opposite station is expected to be " + sol.editedTimeToNextStationOpp + " min";
            }
            else
            {
                body = sol.stationCode + " " + stationname + " returns to be operational.";
            }

            var push = NotificationService.push.Send(title, body);

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
