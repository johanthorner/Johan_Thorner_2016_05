using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JohanThorner_MVC_2016_05
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "start",
              url: "{Stores}/{action}/{id}",
              defaults: new { controller = "Stores", action = "Create", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "Hexa",
               url: "{Sprite}/{action}/{id}",
               defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sprite", action = "Octa", id = UrlParameter.Optional }
            );
        }
    }
}
