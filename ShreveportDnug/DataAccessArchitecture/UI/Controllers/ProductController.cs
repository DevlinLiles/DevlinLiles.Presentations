using System.Linq;
using System.Web.Mvc;
using Core.Entities;
using Core.Interfaces;
using Core.Queries;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        private IRepository _context;

        public ProductController()
        {
        }
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var products = _context.Find<Product>();

            return View(products.ToList());
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id)
        {
            var product = _context.Find<Product>().GetById(id);
            return View(product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View(new Product());
        } 

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Product/Edit/5
 
        public ActionResult Edit(int id)
        {
            var context = _context;
            var item = context.Find<Product>().Where(x => x.ProductID == id).Single();

            return View(item);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new Product());
            }
        }

        //
        // GET: /Product/Delete/5
 
        public ActionResult Delete(int id)
        {
            var context = _context;
            var item = context.Find<Product>().Where(x => x.ProductID == id).Single();
            return View(item);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var context = _context;
                var item = context.Find<Product>().Where(x => x.ProductID == id).Single();
                context.Remove(item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
