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
            List<Transaction> tList = transService.getAllBreakdownsIn12Months();
            foreach(Transaction x in tList)
            {
                switch(x.transactionTime.Month)
                {
                    case 1:
                        ViewBag.Jan += 1;break;
                    case 2:
                        ViewBag.Feb += 1; break;
                    case 3:
                        ViewBag.Mar += 1; break;
                    case 4:
                        ViewBag.Apr += 1; break;
                    case 5:
                        ViewBag.May += 1; break;
                    case 6:
                        ViewBag.Jun += 1; break;
                    case 7:
                        ViewBag.Jul += 1; break;
                    case 8:
                        ViewBag.Aug += 1; break;
                    case 9:
                        ViewBag.Sep += 1; break;
                    case 10:
                        ViewBag.Oct += 1; break;
                    case 11:
                        ViewBag.Nov += 1; break;
                    case 12:
                        ViewBag.Dec += 1; break;
                }
            }
            return View();
        }
    }
}
