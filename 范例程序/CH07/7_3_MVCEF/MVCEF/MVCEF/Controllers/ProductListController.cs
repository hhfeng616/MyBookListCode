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
            var context = new KTStoreEntities(); 
                var products = context.Product;
                return View(products);
        }
    }
}