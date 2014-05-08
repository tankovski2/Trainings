﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GlimpseDemo.Model_Binders;

namespace GlimpseDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapHubs();
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            // Clear all registered view engines
            ViewEngines.Engines.Clear();
            // Add back in just the Razor view engine
            ViewEngines.Engines.Add(new RazorViewEngine());

            ModelBinders.Binders.Add(typeof(DateTime), new SpecialBinder());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        }
    }
}