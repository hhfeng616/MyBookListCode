using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEF.Models;
using System.Data.Entity;

namespace MVCEF.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(string name)
        {
            var context = new KTStoreEntities();
            var products = context.Product.Where(x => x.Name.Contains(name));
            return View(products);
        }

        public ActionResult Update(int id)
        {
            var context = new KTStoreEntities();
            Product product = context.Product.Find(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            var context = new KTStoreEntities();
            context.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index", new { name = product.Name });
        }
        
        public ActionResult Delete(int id = 0)
        {
            var context = new KTStoreEntities();
            Product product = context.Product.Find(id);
            context.Product.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]
        public ActionResult Insert(Product product)
        {
            var context = new KTStoreEntities();
            context.Product.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index", new { name = product.Name });
        }

    }
}