using System;
using System.Web.Mvc;
using System.Web.Routing;
using CustomViewEngine.UI.App_Start;
using CustomViewEngine.UI.ViewEngine;

namespace CustomViewEngine.UI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.Register(RouteTable.Routes);

            //Register your View Engine Here.
            ViewEngines.Engines.Add(new MyViewEngine());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}