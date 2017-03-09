using System.Web.Mvc;
using System.Web.Routing;

namespace CalendArt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Courses", // Route name
                url: "courses/{action}/{id}", // URL with parameters
                defaults: new { controller = "Course", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Events", // Route name
                url: "events/{action}/{id}", // URL with parameters
                defaults: new { controller = "Event", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Reminders", // Route name
                url: "reminders/{action}/{id}", // URL with parameters
                defaults: new { controller = "Reminder", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
