using System;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Web.Mvc;
using WebApp1._27_Routing.Models; // Include your model namespace here

namespace WebApp1._27_Routing.Controllers
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

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = $"{DateTime.Now.Ticks}-{Guid.NewGuid()}"
            };

            return View(errorViewModel);
        }


        public ActionResult StudentInfo1(string id, string name)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }
    }
}
