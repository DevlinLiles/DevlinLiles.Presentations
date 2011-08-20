using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirst.Properties;
using EFCodeFirst.Repository;

namespace EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var context = new AdventureWorksContext(Settings.Default.Connection);
            var products = context.Products.ToList();
            return View(products);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Products()
        {
            var context = new AdventureWorksContext(Settings.Default.Connection);
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
