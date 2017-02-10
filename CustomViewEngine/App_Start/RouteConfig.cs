using System.Web.Routing;
using System.Web.Mvc;

namespace CustomViewEngine.UI.App_Start
{
    public static class RouteConfig
    {
        public static void Register(RouteCollection routes)
        {
            routes.MapRoute("Home", "{controller}/{action}/{id}", new { controller = "home", action = "index", id = UrlParameter.Optional });
        }
    }
}