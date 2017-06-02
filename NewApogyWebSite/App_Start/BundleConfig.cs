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

            bundles.Add(new ScriptBundle("~/javascript/bundle").Include(
                "~/Content/assets/plugins/bootstrap/js/bootstrap.js",
                "~/Content/assets/plugins/back-to-top.js",
                "~/Content/assets/plugins/smoothScroll.js",
                "~/Content/assets/plugins/jquery.parallax.js",
                "~/Content/assets/plugins/counter/waypoints.js",
                "~/Content/assets/plugins/counter/jquery.counterup.min.js",
                "~/Content/assets/plugins/wow-animations/js/wow.js",
                "~/Content/assets/plugins/animated-headline/js/modernizr.js",
                "~/Content/assets/plugins/animated-headline/js/animated-headline.js",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/js/jquery.cubeportfolio.js",
                "~/Content/assets/js/custom.js",
                "~/Content/assets/js/app.js",
                "~/Content/assets/js/plugins/style-switcher.js",
                "~/Content/assets/js/plugins/cube-portfolio/cube-portfolio-lightbox.js"));

            bundles.Add(new StyleBundle("~/stylesheets/bundle").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.css",
                "~/Content/assets/css/style.css",
                "~/Content/assets/css/headers/header-v6.css",
                "~/Content/assets/css/footers/footer-v6.css",
                "~/Content/assets/plugins/animate.css",
                "~/Content/assets/plugins/line-icons/line-icons.css",
                "~/Content/assets/plugins/font-awesome/css/font-awesome.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/css/cubeportfolio.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/custom/custom-cubeportfolio.css",
                "~/Content/assets/plugins/animated-headline/css/animated-headline.css",
                "~/Content/assets/css/theme-colors/blue.css",
                "~/Content/assets/css/theme-skins/dark.css",
                "~/Content/assets/css/custom.css"));

            bundles.Add(new StyleBundle("~/stylesheets/bundle2").Include(
                "~/Content/assets/css/blocks.css",
                "~/Content/assets/css/css-rtl/blocks-rtl.css",
                "~/Content/assets/css/app.css",
                "~/Content/assets/css/css-rtl/app-rtl.css",
                "~/Content/assets/css/pages/shortcode_timeline2.css",
                "~/Content/assets/css/css-rtl/headers/header-v6-rtl.css"));
        }
    }
}
