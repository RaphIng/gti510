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
                defaults: new { controller = "CourseController", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Events", // Route name
                url: "events/{action}/{id}", // URL with parameters
                defaults: new { controller = "EventController", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Reminders", // Route name
                url: "reminders/{action}/{id}", // URL with parameters
                defaults: new { controller = "ReminderController", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
