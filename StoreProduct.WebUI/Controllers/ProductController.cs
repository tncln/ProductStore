using StoreProduct.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreProduct.Business.Manager;
using StoreProduct.Entity;

namespace StoreProduct.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductManager _productManager;
        ICategoryManager _categoryManager;
        public ProductController()
        {
            //Dependency injection
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = _productManager.GetAll().ToList();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Categories = _categoryManager.GetAll().ToList();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product entity)
        {
            try
            {
                _productManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var products = _productManager.Get(id);
            ViewBag.Categories = _categoryManager.GetAll().ToList();
            return View(products);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product entity)
        {
            try
            {
                _productManager.Update(entity);
                TempData["Updated"] = entity.Name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
