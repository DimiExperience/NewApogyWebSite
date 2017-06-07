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
                "~/Content/assets/plugins/jquery/jquery-migrate.js",
                "~/Content/assets/plugins/jquery-appear.js",
                "~/Content/assets/plugins/fancybox/source/jquery.fancybox.pack.js"));

            bundles.Add(new ScriptBundle("~/javascript/bundle").Include(
                "~/Content/assets/plugins/bootstrap/js/bootstrap.js",
                "~/Content/assets/js/plugins/owl-carousel.js",
                "~/Content/assets/plugins/back-to-top.js",
                "~/Content/assets/plugins/smoothScroll.js",
                "~/Content/assets/plugins/jquery.parallax.js",
                "~/Content/assets/js/plugins/parallax-slider.js",
                "~/Content/assets/plugins/counter/waypoints.js",
                "~/Content/assets/plugins/counter/jquery.counterup.min.js",
                "~/Content/assets/plugins/wow-animations/js/wow.js",
                "~/Content/assets/plugins/animated-headline/js/modernizr.js",
                "~/Content/assets/plugins/animated-headline/js/animated-headline.js",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/js/jquery.cubeportfolio.js",
                "~/Content/assets/js/custom.js",
                "~/Content/assets/js/app.js",
                "~/Content/assets/js/plugins/style-switcher.js",
                "~/Content/assets/js/plugins/cube-portfolio/cube-portfolio-lightbox.js",
                "~/Content/assets/js/plugins/fancy-box.js",
                "~/Content/assets/js/plugins/progress-bar.js",
                "~/Scripts/jquery.matchHeight.js",
                "~/Content/assets/plugins/owl-carousel/owl-carousel/owl.carousel.js",
                "~/Content/assets/plugins/wow-animation/js/wow.min.js"));

            bundles.Add(new StyleBundle("~/stylesheets/bundle").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.css",
                "~/Content/assets/css/headers/header-default.css",
                "~/Content/assets/css/headers/header-v6.css",
                "~/Content/assets/css/footers/footer-v6.css",
                "~/Content/assets/css/style.css",
                "~/Content/assets/css/app.css",
                "~/Content/assets/plugins/animate.css",
                "~/Content/assets/plugins/line-icons/line-icons.css",
                "~/Content/assets/plugins/font-awesome/css/font-awesome.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/css/cubeportfolio.css",
                "~/Content/assets/plugins/cube-portfolio/cubeportfolio/custom/custom-cubeportfolio.css",
                "~/Content/assets/plugins/animated-headline/css/animated-headline.css",
                "~/Content/assets/css/theme-colors/blue.css",
                "~/Content/assets/css/theme-skins/dark.css",
                "~/Content/assets/css/custom.css",
                "~/Content/assets/plugins/fancybox/source/jquery.fancybox.css",
                "~/Content/assets/plugins/owl-carousel/owl-carousel/owl.carousel.css",
                "~/Content/assets/plugins/owl-carousel/owl-carousel/owl.theme.css",
                "~/Content/assets/plugins/parallax-slider/css/parallax-slider.css"));

            bundles.Add(new StyleBundle("~/stylesheets/bundle2").Include(
                "~/Content/assets/css/blocks.css",
                "~/Content/assets/css/pages/shortcode_timeline2.css",
                "~/Content/assets/css/pages/shortcode_timeline1.css",
                "~/Content/assets/plugins/sky-forms-pro/skyforms/css/sky-forms.css",
                "~/Content/assets/plugins/sky-forms-pro/skyforms/custom/custom-sky-forms.css",
                "~/Content/assets/plugins/line-icons-pro/styles.css"));
        }
    }
}
