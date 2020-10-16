﻿using System.Web;
using System.Web.Optimization;

namespace A2ZMOVIES
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                          "~/Scripts/bootstrap.js",
                           "~/Scripts/bootbox.js",
                           "~/Scripts/respond.js",
                           "~/Scripts/Datatables/jquery.dataTables.js",
                           "~/Scripts/Datatables/datatables.bootstrap.js",
                           "~/Scripts/toastr.js",
                           "~/Scripts/typeahead.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

          
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/typeahead.css",
                      "~/Content/toastr.css",
                       "~/Content/dataTables/css/dataTables.bootstrap.css"
                     ));
        }
    } 
}