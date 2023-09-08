using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApp1._29_RazorViewEngine.Models; // Include your model namespace here

namespace WebApp1._29_RazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.QueryString["t"] == "")
                ViewBag.message = "Please select a list type";
            else if (Request.QueryString["t"] == "students")
            {
                ViewBag.stype = "students";
                ViewBag.message = "List Of Students";
                List<string> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Student " + i.ToString());
                }
                ViewBag.list = list;
            }
            else if (Request.QueryString["t"] == "teachers")
            {
                ViewBag.stype = "teachers";
                ViewBag.message = "List Of Teachers";
                List<string> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Teacher " + i.ToString());
                }
                ViewBag.list = list;
            }
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
            return View(new ErrorViewModel { RequestId = Guid.NewGuid().ToString() });
        }
    }
}
