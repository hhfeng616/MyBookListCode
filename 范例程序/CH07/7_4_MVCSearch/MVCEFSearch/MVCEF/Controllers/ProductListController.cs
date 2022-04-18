using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEF.Models;

namespace MVCEF.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var context = new KTStoreEntities();
            var products = context.Product.Where(x => x.Name.Contains(name));
            return View(products);
        }

    }
}