using System.Linq;
using System.Web.Mvc;
using BeautifulUI.Properties;
using Core.Entities;
using Core.Interfaces;
using Core.Queries;
using Infrastructure.Implementations;

namespace BeautifulUI.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _context;

        public HomeController()
        {
            _context = new Repository(new AdventureWorksContext(Settings.Default.Connection));
        }

        public ActionResult Index()
        {
            ViewBag.Message = string.Format("Count of Products {0}", 
                _context.Find<Product>().FilterByColor("Blue").Count());

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
