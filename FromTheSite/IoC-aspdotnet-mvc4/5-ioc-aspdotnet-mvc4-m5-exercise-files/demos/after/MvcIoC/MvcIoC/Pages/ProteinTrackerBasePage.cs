using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcIoC.Models;

namespace MvcIoC.Pages
{
    public class ProteinTrackerBasePage : WebViewPage
    {
        public IAnalyticsService AnalyticsService { get; set; }


        public override void Execute()
        {
            
        }
    }
}