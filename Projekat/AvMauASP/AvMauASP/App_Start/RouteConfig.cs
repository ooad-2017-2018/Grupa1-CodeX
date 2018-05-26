    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AvMauASP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            /*routes.MapRoute(
                "ZivotinjePoDatumuPrispeca",
                "zivotinje/primljene/{year}/{month}," +
                new { controller = "Zivotinje", action = "PoDatumuPrispeca" });
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Korisnik", action = "Register", id = UrlParameter.Optional }
            );
        }
    }
}
