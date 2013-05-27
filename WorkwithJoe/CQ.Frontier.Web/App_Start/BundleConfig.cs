using System.Web;
using System.Web.Optimization;

namespace CQ.Frontier.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
						"~/Content/js/vendor/jquery/jquery-2.*",
						"~/Content/js/vendor/bootstrap/bootstrap.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/app").Include(
						"~/Content/js/vendor/angular/angular.min.js",
						"~/Content/js/vendor/angular/angular-resource.min.js",
						"~/Content/js/vendor/angular/underscore-1.4.4.min.js",
						"~/Content/js/app/app.js",
						"~/Content/js/app/Controllers/*Ctrl.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/css/app.css", 
				"~/Content/css/bootstrap.min.css"));

//			bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
//						"~/Content/themes/base/bootstrap.min.css"));
		}
	}
}