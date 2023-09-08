using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace WebApp1._18_FormSubmissionMethods.Controllers
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

        [HttpGet]
        public ActionResult FormGet()
        {
            ViewBag.Name = Request.QueryString["name"];
            ViewBag.Email = Request.QueryString["email"];
            ViewBag.Class = Request.QueryString["class"];
            ViewBag.Address = Request.QueryString["address"];
            return View();
        }

        [HttpPost]
        public ActionResult FormPost(string name, string address, string email, string whichclass)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Class = whichclass;
            ViewBag.Address = address;
            return View();
        }
    }
}
