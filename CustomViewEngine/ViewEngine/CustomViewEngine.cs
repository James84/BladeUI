using System.Web.Mvc;

namespace CustomViewEngine.UI.ViewEngine
{
    public class CustomViewEngine : VirtualPathProviderViewEngine
    {
        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            throw new System.NotImplementedException();
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            throw new System.NotImplementedException();
        }
    }
}