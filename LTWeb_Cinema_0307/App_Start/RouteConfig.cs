using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LTWeb_Cinema_0307
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Movies",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LTWeb_Cinema_0307.Controllers" }
            );
            routes.MapRoute(
                name: "admin_Movies",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "LTWeb_Cinema_0307.Areas.admin.Controllers" }
            ); 
        }
    }
}
