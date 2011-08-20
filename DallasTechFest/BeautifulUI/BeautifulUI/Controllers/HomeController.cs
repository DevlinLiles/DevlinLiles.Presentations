using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautifulUI.Properties;
using Core.Domain.Entities;
using Core.Interfaces;
using Infrastructure;
using Infrastructure.Queries;

namespace BeautifulUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult List()
        {
            var items = _repository.Find<Product>().GetAllBlueProducts().ToList();
            return View(items);
        }
    }
}
