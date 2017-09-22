using mvc5.Context;
using mvc5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mvc5.Controllers
{
    public class productController : Controller
    {

        private StoreContext db = new StoreContext();


        // GET: product
        public ActionResult Index()
        {
            return View(db.products.ToList());
        }

        // GET: product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             
            var product = db.products.Find(id);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: product/Create
        [HttpPost]
        public ActionResult Create(product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }

        // GET: product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = db.products.Find(id);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    

        // POST: product/Edit/5
        [HttpPost]
        public ActionResult Edit(product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = db.products.Find(id);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    

        // POST: product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product = db.products.Find(id);
                    if(product== null)
                    {
                        return HttpNotFound();
                    }
                    db.products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(product);

            }
            catch
            {
                return View();
            }
        }
    }
}
