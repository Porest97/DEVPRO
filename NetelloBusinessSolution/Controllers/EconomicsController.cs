using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetelloBusinessSolution.Controllers
{
    public class EconomicsController : Controller
    {
        // GET: Economics MainView
        public ActionResult Economics()
        {
            return View();
        }

        // GET: Economics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Economics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Economics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Economics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Economics/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Economics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Economics/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}