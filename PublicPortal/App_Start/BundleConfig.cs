using System.Web;
using System.Web.Optimization;

namespace PublicPortal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Added by Mohammad Ahmad 23/10/2017
            bundles.Add(new ScriptBundle("~/bundles/Layout").Include(
                "~/Scripts/core/libraries/jquery.min.js",
                "~/Scripts/ui/tether.min.js",
                "~/Scripts/core/libraries/bootstrap.min.js",
                "~/Scripts/ui/perfect-scrollbar.jquery.min.js",
                "~/Scripts/ui/unison.min.js",
                "~/Scripts/ui/blockUI.min.js",
                "~/Scripts/ui/jquery.matchHeight-min.js",
                "~/Scripts/ui/screenfull.min.js",
                "~/Scripts/charts/chart.min.js",
                "~/Scripts/bootstrap-datepicker/moment-with-locales.min.js",
                "~/Scripts/bootstrap-datepicker/bootstrap-datetimepicker.min.js",
                "~/Scripts/core/app.js",
                "~/Scripts/core/app-menu.js",
                "~/Scripts/tableSaw/tablesaw.js",
                "~/Scripts/tableSaw/tablesaw-init.js"
                ));
            // Added by Mohammad Ahmad 23/10/2017
            bundles.Add(new StyleBundle("~/Content/Layout").Include(
                "~/Content/assets/css-rtl/bootstrap.css",
                "~/Content/assets/bootstrap-datetimepicker.min.css",
                "~/Content/assets/fonts/icomoon.css",
                "~/Content/assets/fonts/flag-icon-css/css/flag-icon.min.css",
                "~/Content/assets/css-rtl/bootstrap-extended.css",
                "~/Content/assets/css-rtl/app.css",
                "~/Content/assets/css-rtl/colors.css",
                "~/Content/assets/css-rtl/custom-rtl.css",
                "~/Content/assets/css-rtl/core/menu/menu-types/vertical-menu.css",
                "~/Content/assets/css-rtl/core/menu/menu-types/vertical-overlay-menu.css",
                "~/Content/assets/css-rtl/core/colors/palette-gradient.css",
                "~/Content/assets/style-rtl.css",
                "~/Content/assets/vendors/css/tableSaw/tableSaw.css"));

            bundles.Add(new ScriptBundle("~/bundles/Adminjquiry").Include(
"~/Scripts/jquery-ui/jquery-ui.js",
"~/Scripts/jquery-ui/jquery-ui-1.10.2.custom.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/sweetalert").Include(
                        "~/Scripts/sweetalert/sweetalert2.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                       "~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                       "~/Content/themes/base/all.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-rtl").Include(
                      "~/Scripts/bootstrap-rtl.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-rtl.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
"~/Scripts/bootstrap-datepicker/moment-with-locales.min.js",
          "~/Scripts/bootstrap-datepicker/bootstrap-datetimepicker.js",

          "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-rtl.css",
                      "~/Content/PagedList.css",
                      "~/Scripts/jquery-ui/jquery-ui-1.10.1.custom.min.css",
                      //"~/Content/bootstrap-datetimepicker.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/picker")
                .Include(
                "~/Scripts/bootstrap-datepicker/js/bootstrap-datepicker.js"
                ));

            bundles.Add(new StyleBundle("~/Content/assets").Include(
                      "~/Content/assets/style.css"));
        }
    }
}
