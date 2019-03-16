using OOPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOPTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Houseclass hc = new Houseclass();
            hc.Guestwelcomemessage();
            hc.purposeofVisit();
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
    }
}