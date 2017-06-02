using System.Web;
using System.Web.Optimization;

namespace NewApogyWebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/jquery/bundle").Include(
                "~/Content/assets/plugins/jquery/jquery.js",
                "~/Content/assets/plugins/jquery/jquery-migrate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/javascript/bundle").Include(
                "~/Content/assets/plugins/bootstrap/js/bootstrap.min.js",
                "~/Content/assets/plugins/back-to-top.js",
                "~/Content/assets/plugins/smoothScroll.js",
                "~/Content/assets/plugins/jquery.parallax.js",
                "~/Content/assets/plugins/counter/waypoints.min.js",
                "~/Content/assets/plugins/counter/jquery.counterup.min.js",
                "~/Content/assets/plugins/wow-animations/js/wow.min.js",
                "~/Content/assets/plugins/animated-headline/js/modernizr.js",
                "~/Content/assets/plugins/animated-headline/js/animated-headline.js",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/js/jquery.cubeportfolio.min.js",
                "~/Content/assets/js/custom.js",
                "~/Content/assets/js/app.js",
                "~/Content/assets/js/plugins/style-switcher.js",
                "~/Content/assets/js/plugins/cube-portfolio/cube-portfolio-lightbox.js"));

            bundles.Add(new StyleBundle("~/stylesheets/bundle").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/assets/css/style.css",
                "~/Content/assets/css/headers/header-v6.css",
                "~/Content/assets/css/footers/footer-v6.css",
                "~/Content/assets/plugins/animate.css",
                "~/Content/assets/plugins/line-icons/line-icons.css",
                "~/Content/assets/plugins/font-awesome/css/font-awesome.min.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/css/cubeportfolio.min.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/custom/custom-cubeportfolio.css",
                "~/Content/assets/plugins/animated-headline/css/animated-headline.css",
                "~/Content/assets/css/theme-colors/blue.css",
                "~/Content/assets/css/theme-skins/dark.css",
                "~/Content/assets/css/custom.css"));
        }
    }
}
