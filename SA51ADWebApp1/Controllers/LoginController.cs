using Microsoft.AspNetCore.Mvc;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Controllers
{
    public class LoginController : Controller
    {
        protected Database dbcontext;

        public LoginController (Database dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        [Route("/")]
        [Route("/login")]
        public IActionResult DisplayLoginForm()
        {
            Admin newLogin = new Admin();
            return View(newLogin);
        }

        [HttpPost]
        public IActionResult Login(Admin newLogin)
        {
            return View("Home");
        }

        [Route("/logout")]
        public IActionResult Logout()
        {
            return View("Logout");
        }
    }
}
