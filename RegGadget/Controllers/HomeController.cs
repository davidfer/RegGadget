using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegGadget.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Helping communities grow participation";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We want to hear from you, please tell us how we can help or improve Register Gadget.";

            return View();
        }
    }
}