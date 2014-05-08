using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;

namespace GlimpseDemo.Plugins
{
    public class SnapShotTab : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
            var requestContext = context.GetRequestContext<HttpContextBase>();
            if (requestContext.CurrentNotification == RequestNotification.BeginRequest)
            {
                context.TabStore.Set("BeginGCTotal", GC.GetTotalMemory(true));
                context.TabStore.Set("BeginTimeUTC", DateTime.UtcNow);
                return null;
            }

            var endGCTotal = GC.GetTotalMemory(true);
            var beginGCTotal = context.TabStore.Get("BeginGCTotal");
            var endTimeUTC = DateTime.UtcNow;
            var beginTimeUTC = (context.TabStore.Get("BeginTimeUTC") as DateTime?) ?? DateTime.UtcNow;
            var millisecondsElapsed = endTimeUTC.Subtract(beginTimeUTC).Milliseconds;

            var memorySection = new TabSection("Begin Request", "End Request");
            memorySection.AddRow()
                         .Column(beginGCTotal).Strong()
                         .Column(endGCTotal).Strong().WarnIf(endGCTotal > (long)beginGCTotal);

            var timeSection = new TabSection("Start Time UTC", "End Time UTC", "Time Elapsed (Milliseconds)");
            timeSection.AddRow()
                       .Column(beginTimeUTC).Emphasis()
                       .Column(endTimeUTC).Emphasis()
                       .Column(millisecondsElapsed).UnderlineIf(millisecondsElapsed > 2000).Loading();


            var plugin = Plugin.Create("Section", "Data");
            plugin.AddRow().Column("Memory Info").Column(memorySection).Ms();
            plugin.AddRow().Column("Time Info").Column(timeSection);

            return plugin;
        }

        public override string Name
        {
            get { return "SnapShot Tab"; }
        }

        public override RuntimeEvent ExecuteOn
        {
            get { return RuntimeEvent.BeginRequest | RuntimeEvent.EndRequest; }
        }
    }
}