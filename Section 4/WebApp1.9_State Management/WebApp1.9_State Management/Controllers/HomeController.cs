﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1._9_State_Management.Controllers
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
        public ViewResult ViewDataSubmit()
        {
            ViewData["name"] = Request.Form["name"];
            ViewData["address"] = Request.Form["address"];
            ViewData["class"] = Request.Form["class"];
            ViewData["year"] = Request.Form["year"];

            return View();
        }

        [HttpPost]
        public ViewResult ViewBagSubmit()
        {
            ViewBag.name = Request.Form["name"];
            ViewBag.address = Request.Form["address"];
            ViewBag.sclass = Request.Form["sclass"];
            ViewBag.year = Request.Form["year"];

            return View();
        }

        [HttpPost]
        public ActionResult TempDataRedirect()
        {
            TempData["name"] = Request.Form["name"].ToString();
            TempData["address"] = Request.Form["address"].ToString();
            TempData["class"] = Request.Form["class"].ToString();
            TempData["year"] = Request.Form["year"].ToString();

            return RedirectToAction("TempDataSubmit");
        }

        public ViewResult TempDataSubmit()
        {
            var model = TempData["name"];
            return View();
        }
    }
}