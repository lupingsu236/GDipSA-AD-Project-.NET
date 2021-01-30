using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Controllers
{
    public class LoginController : Controller
    {
        [Route("/")]
        [Route("/login")]
        public IActionResult DisplayLoginForm()
        {
            return View("Login");
        }

        [Route("/logout")]
        public IActionResult Logout()
        {
            return View("Logout");
        }
    }
}
