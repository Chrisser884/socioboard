﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Socioboard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           // routes.MapRoute(
           //    name: "Admin",
           //    url: "Admin/{action}/{id}",
           //    defaults: new { controller = "AdminLogin", action = "Index", id = UrlParameter.Optional }
           //);
            routes.MapRoute(
<<<<<<< HEAD
             name: "CompanyDashboard",
              url: "Company/{q}",
              defaults: new { controller = "CompanyDashboard", action = "Company", q = UrlParameter.Optional }
              );
=======
            name: "CompanyDashboard",
             url: "company/{q}",
             defaults: new { controller = "CompanyDashboard", action = "Company", q = UrlParameter.Optional }
             );
>>>>>>> e052534b7a2a3744cad9dddbc3c6acccf394ca7b
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}