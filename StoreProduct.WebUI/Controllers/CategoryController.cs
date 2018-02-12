﻿using StoreProduct.Business.Abstract;
using StoreProduct.Business.Manager;
using StoreProduct.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreProduct.WebUI.Controllers
{
    public class CategoryController : Controller
    {
       
        ICategoryManager _categoryManager;
        public CategoryController()
        {
            //Dependency injection
          
            _categoryManager = new CategoryManager();
        }
        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryManager.GetAll().ToList();
            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category entity)
        {
            try
            {
                _categoryManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _categoryManager.Get(id);
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category entity)
        {
            try
            {
                _categoryManager.Update(entity);
                TempData["Updated"] = entity.Name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
