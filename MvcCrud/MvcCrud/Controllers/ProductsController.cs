using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class ProductsController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        // GET: Products
        public ActionResult Index()
        {
            var productList = db.Products.ToList();
            return View(productList);
        }
        public ActionResult Detail(int id)
        {
            return View(db.Products.Find(id));
        }

    }
}