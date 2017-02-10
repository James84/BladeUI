using System.Web.Mvc;

namespace CustomViewEngine.UI.ViewEngine
{
    public class MyViewEngine : VirtualPathProviderViewEngine
    {
        public MyViewEngine()
        {
            ViewLocationFormats = new[] {"~/Views/{1}/{0}.myview", "~/Views/Shared/{0}.myview"};
            PartialViewLocationFormats = new[] {"~/Views/{1}/{0}", "~/Views/Shared/{0}.myview"};
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var physicalPath = controllerContext.HttpContext.Server.MapPath(partialPath);
            return new MyView(physicalPath);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var physicalPath = controllerContext.HttpContext.Server.MapPath(viewPath);
            return new MyView(physicalPath);
        }
    }
}