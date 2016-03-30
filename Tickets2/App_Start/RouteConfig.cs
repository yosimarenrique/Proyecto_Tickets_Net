using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tickets2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Solicitudes", action = "Index", id = UrlParameter.Optional }
             );

            routes.MapRoute(
               name: "Vista1",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Enviaremail", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Vista2",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Enviaremail", action = "Index2", id = UrlParameter.Optional }
          );

        }
    }
}
