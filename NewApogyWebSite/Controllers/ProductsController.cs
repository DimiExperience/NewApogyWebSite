using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApogyWebSite.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Apogy()
        {
            ViewBag.Title = "Apogy";

            return View();
        }
        public ActionResult ApogyEvents()
        {
            ViewBag.Title = "Apogy Events";

            return View();
        }
        public ActionResult Podium()
        {
            ViewBag.Title = "Podium";

            return View();
        }
    }
}
