using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SA51ADWebApp1.Models;
using SA51ADWebApp1.Service;
using System;


namespace SA51ADWebApp1.Controllers
{
    public class LoginController : Controller
    {
        protected IAdminService adminService;

        public LoginController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [Route("/")]
        [Route("/login")]
        public IActionResult Login()
        {
            string sessionId = HttpContext.Request.Cookies["sessionId"];
            if (sessionId != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            Admin newLogin = new Admin();
            return View(newLogin);
        }

        [HttpPost]
        public IActionResult ValidateLogin(Admin newLogin)
        {
            if (adminService.validateUser(newLogin.username, newLogin.password))
            {
                //string sessionId = System.Guid.NewGuid().ToString();
                string sessionId = adminService.getValidUserId(newLogin.username).ToString();
                string sessionName = adminService.getUserById(Convert.ToInt32(sessionId));
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("sessionId", sessionId, options);
                Response.Cookies.Append("sessionName", sessionName, options);
            }
            else
            {
                ViewData["errorMsg"] = "Incorrect username or password";
                return View("Login");
            }
            return RedirectToAction("Dashboard","Home");
        }

        [Route("/logout")]
        public IActionResult Logout()
        {
            string sessionId = Request.Cookies["sessionId"];
            if (sessionId == null)
            {
                return View("Login");
            }
            else
            {
                //clearSessionsAndCookies
                Response.Cookies.Delete("sessionId");
                return View("Logout");
            }
        }
    }
}
