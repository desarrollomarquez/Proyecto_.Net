using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDG_DB_FIRST.Controllers
{
    public class TipoVehiculoController : Controller
    {
        // GET: TipoVehiculo
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoVehiculo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoVehiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoVehiculo/Create
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

        // GET: TipoVehiculo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoVehiculo/Edit/5
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

        // GET: TipoVehiculo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoVehiculo/Delete/5
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
