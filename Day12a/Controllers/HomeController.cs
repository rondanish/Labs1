using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace Day12a.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[RequireHttps]
        public ActionResult About()
        {

            //if (this.User.IsInRole("Admin")
            ViewBag.Message = "Your application description page.";

            return View();
        }
  

        public ActionResult Contact()
        {
            var user = this.User.Identity as ClaimsIdentity;

            if (!user.HasClaim("CanEditProducts", "true"))
            {
                return new HttpUnauthorizedResult("Go away");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}