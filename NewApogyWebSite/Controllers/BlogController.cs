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

        public ActionResult Millennial()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult SocialLearning()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult PharmaSales()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult Forgetfulness()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult DistruptiveTech()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult BecomingApogy()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult DealKiller()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }

        public ActionResult HateMobileApps()
        {
            ViewBag.Title = "Blog Post";

            return View();
        }
    }
}
