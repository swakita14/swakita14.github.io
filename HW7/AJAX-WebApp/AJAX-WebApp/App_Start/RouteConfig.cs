﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AJAX_WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AJAX", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Search",
               url: "{controller}/{action}/{search}",
               defaults: new { controller = "Translate", action = "Sticker",}
           );
        }
    }
}
