using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HipposABP.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Patrons()
        {
            return View();
        }

        public ActionResult Roles()
        {
            return View();
        }
        public ActionResult Appointments()
        {
            return View();
        }

        public ActionResult Staffs()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Status()
        {
            return View();
        }

        public ActionResult ExistingPatronBooking()
        {
            return View();
        }
    }
}