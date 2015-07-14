using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MoviesCustomRoute",
                url: "movie/{*path}",
                defaults: new { controller = "Movies", action = "Index" }
            );

            routes.MapRoute(
                name: "BlogById",
                url: "blog/{entryId}",
                defaults: new { controller = "Blog", action = "GetEntryById"},
                constraints: new { entryId = @"\d+"}
            );
            
            routes.MapRoute(
                name: "BlogByDate",
                url: "blog/{entryDate}",
                defaults: new { controller = "Blog", action= "GetEntryByDate"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
