﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundsharpMVC.Controllers
{
    public class CdDiscManController : Controller
    {
        // GET: CdDiscMan
        public ActionResult Index()
        {
            return View();
        }

        // GET: CdDiscMan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CdDiscMan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CdDiscMan/Create
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

        // GET: CdDiscMan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CdDiscMan/Edit/5
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
                return View();
            }
        }

        // GET: CdDiscMan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CdDiscMan/Delete/5
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
