using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate next;

        public AuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        
        public async Task Invoke(HttpContext context)
        {
            string controller = (string)context.Request.RouteValues["controller"];

            if (controller != "Login" && controller != "API")
            {
                string sessionId = context.Request.Cookies["sessionId"];
                if (sessionId == null)
                {
                    context.Response.Redirect("http://" + context.Request.Host + "/");
                    return;
                }
                else
                {
                    // refresh cookie everytime a request pass through this.
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddDays(1);
                    context.Response.Cookies.Append("sessionId", sessionId, options);
                }
            }

            await next(context);
        }
    }
}
