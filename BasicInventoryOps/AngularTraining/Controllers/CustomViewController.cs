using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTraining.Controllers.CustomView
{
    public class CustomViewController : Controller
    {
        // GET: CustomView
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomView/Create
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

        // GET: CustomView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomView/Edit/5
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

        // GET: CustomView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomView/Delete/5
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
