using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glimpse.Core;
using GlimpseDemo.App_Start;

namespace GlimpseDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDog dog;

        public HomeController(IDog dog)
        {
            this.dog = dog;
        }

        public string Message(DateTime dateTime)
        {
            Trace.TraceInformation("Date was: {0}",dateTime);
            Trace.TraceInformation("Month: {0}", dateTime.Month);
            return dateTime.ToString();
        }

        public ActionResult Index(string name = "")
        {
            Trace.Write(dog.Bark());
            Trace.Write("This is a trace message");
            Trace.TraceWarning("Warning:");
            Trace.TraceInformation("Info");
            Trace.TraceError("Error:");
            Trace.Write("Category", "Message");
            Session["testData"] = "test value";
            ViewBag.Message = String.Format("Hi {0}, Modify this template to jump-start your ASP.NET MVC application.", name);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Chat()
        {
            return View();
        }
    }
}
