using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.EnterpriseServices;
using IdentityServer3.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using FileResult = System.Web.Mvc.FileResult;
using ContentResult = System.Web.Mvc.ContentResult;
using RedirectResult = System.Web.Mvc.RedirectResult;
using RedirectToRouteResult = System.Web.Mvc.RedirectToRouteResult;

namespace _1._4_Various_ActionResults.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return (IActionResult)View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return (IActionResult)View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return (IActionResult)View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public ContentResult StudentAsString()
        {
            return Content("The name of the student is Walter Smith and he is in Grade 7.");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name of the student is <b>Walter Smith</b> and he is in Grade 7.";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");
        }

        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return RedirectToRoute(new { controller = "Home", action = "StudentAsView" });
        }

        public FileResult StudentAsFileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StudentData.txt"));
            string fileName = "StudentData.txt";
            return File(fileBytes, "application/octet-stream", fileName);
        }

        public JsonResult StudentAsJSONResult()
        {
            string data = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StudentData.json"));
            JObject json = JObject.Parse(data);
            return Json(json);
        }

        public ViewResult StudentList()
        {
            return View();
        }
    }
}