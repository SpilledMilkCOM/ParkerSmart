﻿using System.Web;
using System.Web.Optimization;

namespace ParkerSmart
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			// JQuery includes

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

			// Bootstrap includes

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));

			// All the STYLE includes

			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/iconic-bootstrap.css", "~/Content/site.css"));

			// cbpAnimatedHeader depends on classie to toggle/replace the class.

			bundles.Add(new ScriptBundle("~/bundles/classie").Include("~/Scripts/classie.js"));

			// Adding animated compaction of the navbar

			bundles.Add(new ScriptBundle("~/bundles/cbpAnimatedHeader").Include("~/Scripts/cbpAnimatedHeader.min.js"));

			// http://daneden.github.io/animate.css/
			bundles.Add(new StyleBundle("~/Content/animate").Include("~/Content/animate.css"));

			// Adding the "custom" scripts to a bundle.

			bundles.Add(new ScriptBundle("~/bundles/parkersmart").Include("~/Scripts/parkersmart.js"));
		}
	}
}
