using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundsharpMVC.Controllers
{
    public class MemorecorderController : Controller
    {
        // GET: Memorecorder
        public ActionResult Index()
        {
            return View();
        }

        // GET: Memorecorder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Memorecorder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memorecorder/Create
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

        // GET: Memorecorder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Memorecorder/Edit/5
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

        // GET: Memorecorder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Memorecorder/Delete/5
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
