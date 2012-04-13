using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Models;
using DataAccess;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace Website.Controllers
{
    public static class IoC
    {
        private static IWindsorContainer container;

        static IoC()
        {
            container = new WindsorContainer();
            container.Register(
                AllTypes.FromThisAssembly()
                .Pick().WithServiceAllInterfaces(),
                AllTypes.FromAssemblyContaining<IRepository>()
                .Pick().WithServiceAllInterfaces()
                );
        }

        public static T Resolve<T>() where T : class
        {
            return container.Resolve<T>();
        }
    }
    public class HomeController : Controller
    {
        private IProductDataService dataSvc;

        public HomeController(IProductDataService dataSvc)
        {
            this.dataSvc = dataSvc;
        }

        public HomeController()
            : this(IoC.Resolve<IProductDataService>())
        {
        }

        public ActionResult Index()
        {
            return View(new IndexViewModel() { Products =  dataSvc.GetProducts() });
        }

    }

    public interface IProductDataService
    {
        IEnumerable<ProductViewModel> GetProducts();
    }

    public class ProductDataService : IProductDataService
    {
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var repo = new Repository();
            return repo.AsQueryable<Product>()
                .Select(m => new ProductViewModel { Name = m.Name, Description = "Foo", Color = m.Color })
                .ToList();
        }
    }
}
