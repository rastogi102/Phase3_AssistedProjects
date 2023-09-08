using System;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Web.Mvc;
using WebApp1._25_PartialViews.Models; // Include your model namespace here

namespace WebApp1._25_PartialViews.Controllers
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

        public ViewResult StudentInfo()
        {
            return View();
        }

        public ViewResult TeacherInfo()
        {
            return View();
        }

        public ActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = $"{DateTime.Now.Ticks}-{Guid.NewGuid()}"
                // You can add additional properties like Message or StackTrace if needed
            };

            return View(errorViewModel);
        }


    }
}
