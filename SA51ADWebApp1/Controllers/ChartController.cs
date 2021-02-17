using Microsoft.AspNetCore.Mvc;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Controllers
{
    public class ChartController : Controller
    {
        protected ITransactionService transService;
        public ChartController(ITransactionService transService)
        {
            this.transService = transService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Analytics";
            List<Transaction> tList = transService.getAllBreakdownsIn6Months();
            ViewBag.breakdownList = tList;
            return View();
        }
    }
}
