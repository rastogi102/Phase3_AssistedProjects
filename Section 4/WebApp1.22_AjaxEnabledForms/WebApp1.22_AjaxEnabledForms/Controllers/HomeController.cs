using System;
using System.Text;
using System.Web.Mvc;
using WebApp1._22_AjaxEnabledForms.Models; // Make sure to include your model namespace here

namespace WebApp1._22_AjaxEnabledForms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentModel model)
        {
            StringBuilder sb = new StringBuilder("Form data:\n");
            sb.Append(model.Name + ", " + model.Address + "," + model.Class + "," + model.Email);
            return Content(sb.ToString());
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
    }
}
