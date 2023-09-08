using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1._10_HTMLForms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // Append the code from the first HomeController here
        public ActionResult FormGet()
        {
            ViewData["name"] = Request.QueryString["name"];
            ViewData["email"] = Request.QueryString["email"];
            ViewData["class"] = Request.QueryString["class"];
            ViewData["address"] = Request.QueryString["address"];
            return View();
        }

        [HttpPost]
        public ActionResult FormPost(string name, string address, string email, string whichclass)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["class"] = whichclass;
            ViewData["address"] = address;
            return View();
        }
    }
}
    
