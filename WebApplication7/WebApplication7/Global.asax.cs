using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication7
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // also known as Main
            System.Net.ServicePointManager.DefaultConnectionLimit = 2000;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
