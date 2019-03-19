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
            // polymorphism 
            hc.Guestwelcomemessage();
            hc.purposeofVisit();
            // chaining examples
            Houseclass hcChain1 = new Houseclass(false);
            Houseclass hcChain2 = new Houseclass();
            // static class method call
            int ageMul = StaticClsPerson.calculate();
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