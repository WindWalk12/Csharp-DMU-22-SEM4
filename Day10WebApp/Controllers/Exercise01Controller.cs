using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50, "Crazy daves", "grandcru.jpg");
            ViewBag.Glass = glass;
            Product bin = new Product("Bin", 99.0, "Crazy daves", "bin_35l.jpg");
            ViewBag.Bin = bin;
            Product knife = new Product("Knife 9000", 9999.99, "Crazy daves", "st_knife.jpg");
            ViewBag.Knife = knife;
			
            return View();
        }
    }
}
