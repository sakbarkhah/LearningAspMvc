using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearningAspMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //For StudentController > Search
            //routes.MapRoute(
            //    "SelectorDemo",
            //    "SelectorDemo/{name}",
            //    defaults : new { controller = "SelectorDemo", action = "Search", name = UrlParameter.Optional}
            //);
        }
    }
}
