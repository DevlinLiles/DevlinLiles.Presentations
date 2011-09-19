using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Entities;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var products = new AdventureWorksContext().Products;

            return View(products.ToList());
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id)
        {
            var product = new AdventureWorksContext().Products.Where(x => x.ProductID == id).Single();
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
            var context = new AdventureWorksContext();
            var item = context.Products.Where(x => x.ProductID == id).Single();

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
            var context = new AdventureWorksContext();
            var item = context.Products.Where(x => x.ProductID == id).Single();
            return View(item);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var context = new AdventureWorksContext();
                var item = context.Products.Where(x => x.ProductID == id).Single();
                context.Products.Remove(item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
