using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace CQ.Frontier.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			routes.MapRoute(
				name: "Login",
				url: "Login",
				defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "Default",
                url: "{controller}/{action}/{id}",
				defaults: new { controller = "App", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}