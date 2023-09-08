using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApp1._16_Validations.Models; // Make sure to include your model namespace here

namespace WebApp1._16_Validations.Controllers
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

        [HttpPost]
        public ActionResult FormAction(Student student)
        {
            if (ModelState.IsValid)
            {
                return Content("Form data is valid.");
            }
            else
            {
                StringBuilder sb = new StringBuilder("");

                foreach (var value in ModelState.Values)
                {
                    if (value.Errors.Count > 0)
                    {
                        for (int i = 0; i < value.Errors.Count; i++)
                            sb.Append(value.Errors[i].ErrorMessage + "\n");
                    }
                }
                return Content("Form data is invalid with " + ModelState.Values.Sum(v => v.Errors.Count).ToString() + " errors:\n " + sb.ToString());
            }
        }
    }
}
