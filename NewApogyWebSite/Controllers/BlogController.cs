using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApogyWebSite.Controllers
{
    public class BlogController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Blog";

            return View();
        }
    }
}
