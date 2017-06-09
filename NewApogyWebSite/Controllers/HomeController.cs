using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApogyWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            if (TempData["toastr"] != null)
            {
                ViewBag.Toastr = TempData["toastr"];
                TempData.Remove("toastr");
            }
            return View();
        }
    }
}
