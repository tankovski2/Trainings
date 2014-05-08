using BuildMyOwnFramework.Data;
using BuildMyOwnFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildMyOwnFramework.Controllers
{
    public class HomeController : BuildMyOwnFrameworkController
    {
        public HomeController(ApplicationDbContext context)
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}