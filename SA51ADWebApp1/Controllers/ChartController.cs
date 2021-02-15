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
            int m0 = 0, m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0, m7 = 0, m8 = 0, m9 = 0, m10 = 0, m11 = 0;
            foreach(Transaction x in tList)
            {
                switch(x.transactionTime.Month)
                {
                    case 1:
                        m0 += 1; break;
                    case 2:
                        m1 += 1; break;
                    case 3:
                        m2 += 1; break;
                    case 4:
                        m3 += 1; break;
                    case 5:
                        m4 += 1; break;
                    case 6:
                        m5 += 1; break;
                    case 7:
                        m6 += 1; break;
                    case 8:
                        m7 += 1; break;
                    case 9:
                        m8 += 1; break;
                    case 10:
                        m9 += 1; break;
                    case 11:
                        m10 += 1; break;
                    case 12:
                        m11 += 1; break;
                }
            }
            ViewBag.Jan = m0; ViewBag.Feb = m1; ViewBag.Mar = m2; ViewBag.Apr = m3; ViewBag.May = m4; ViewBag.Jun = m5;
            ViewBag.Jul = m6; ViewBag.Aug = m7; ViewBag.Sep = m8; ViewBag.Oct = m9; ViewBag.Nov = m10; ViewBag.Dec = m11;
            return View();
        }
    }
}
