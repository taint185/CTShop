﻿using System.Web;
using System.Web.Optimization;

namespace CTShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/main.js",
                      "~/Scripts/script.slider.js",
                      "~/Scripts/sticky.js",
                      "~/Scripts/jquery.easing.1.3.min.js",
                      "~/Scripts/bxsslider.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/responsive.css",
                      "~/Content/style.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/font-awesome.min.css"));
        }
    }
}
