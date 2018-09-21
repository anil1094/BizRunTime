using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        public ViewResult Index()
        {
            
            ViewData["key"] = "anil";
            ViewData["products"] = new List<string>()
            {
                "svmsung TV",
                "nike causal"
            };

            ViewBag.name = "David";
            ViewBag.category = new List<string>()
            {
                "electronic",
                "shoes"
            };
            return View();
        }
    }
}