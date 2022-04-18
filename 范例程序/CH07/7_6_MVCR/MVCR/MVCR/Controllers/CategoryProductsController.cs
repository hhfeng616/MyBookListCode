using MVCR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCR.Controllers
{
    public class CategoryProductsController : Controller
    {
        // GET: CategoryProducts
        public ActionResult Index()
        {
            var context = new KTStoreEntities();
            ViewBag.cid = -1;
            return View(context.Category);
        }
        [HttpPost]
        public ActionResult Index(int cid)
        { 
            var context = new KTStoreEntities();
            ViewBag.cid = cid;
            return View(context.Category);
        }
    }
}
