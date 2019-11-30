using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECommerce.Models;
using MelikeEryilmaz.Models;

namespace MelikeEryilmaz.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private August_30_DbEntities db = new August_30_DbEntities();

        // GET: Admin/Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Categories).Include(p => p.ProductDetails);
            return View(products.ToList());
        }

        // GET: Admin/Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Admin/Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            ViewBag.ProductId = new SelectList(db.ProductDetails, "ProductId", "Description");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]

        public ActionResult Create([Bind(Include = "ProductId,CategoryId,ProductName,ImageUrl")] Products products,HttpPostedFileBase file,string editor1)
        {
            if (ModelState.IsValid)
            {
                ImageUpload imageupload = new ImageUpload();

                if (file!=null)
                {
                    products.ImageUrl = imageupload.ImageResize(file, 255, 255);
                }
                products.ProductDetails.Description = editor1;
                products.ProductDetails.RegisterDate = DateTime.Now;
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", products.CategoryId);
            ViewBag.ProductId = new SelectList(db.ProductDetails, "ProductId", "Description", products.ProductId);
            return View(products);
        }

        // GET: Admin/Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", products.CategoryId);
            ViewBag.ProductId = new SelectList(db.ProductDetails, "ProductId", "Description", products.ProductId);
            return View(products);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,CategoryId,ProductName,ImageUrl,ProductDetails")] Products products,
            HttpPostedFile file)
        {
            if (ModelState.IsValid)
            {
                var editToProduct = db.Products.Find(products.ProductId);
                editToProduct.CategoryId = products.CategoryId;
                ImageUpload imageUpload = new ImageUpload();
                if (file != null)
                {
                    editToProduct.ImageUrl = imageUpload.ImageResize(file, 255, 237);
                }
                editToProduct.ProductName = editToProduct.ProductName;
                editToProduct.ProductDetails.Description = products.ProductDetails.Description;
                editToProduct.ProductDetails.isAvailibity = products.ProductDetails.isAvailibity;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", products.CategoryId);
            ViewBag.ProductId = new SelectList(db.ProductDetails, "ProductId", "Description", products.ProductId);
            return View(products);
        }

        // GET: Admin/Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.Products.Find(id);
            db.Products.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
