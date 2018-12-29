using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppMC;

namespace WebAppMC.Controllers
{
    public class EntidadsController : Controller
    {
        private MilenioCloudEntities db = new MilenioCloudEntities();

        // GET: Entidads
        public ActionResult Index()
        {
            var entidad = db.Entidad.Include(e => e.Entidad2).Include(e => e.Ubicacion);
            return View(entidad.ToList());
        }

        // GET: Entidads/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            return View(entidad);
        }

        // GET: Entidads/Create
        public ActionResult Create()
        {
            ViewBag.Entidad_Padre = new SelectList(db.Entidad, "Codigo_Id", "Nombre");
            ViewBag.Ubicacion_Id = new SelectList(db.Ubicacion, "Codigo_Id", "Direccion");
            return View();
        }

        // POST: Entidads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo_Id,Nit,Nombre,CodigoEntidad,CodigoDane,FiniFiscal,FfinFiscal,Entidad_Padre,Ubicacion_Id,Created_At,Updated_At")] Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                entidad.Codigo_Id = Guid.NewGuid();
                db.Entidad.Add(entidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Entidad_Padre = new SelectList(db.Entidad, "Codigo_Id", "Nombre", entidad.Entidad_Padre);
            ViewBag.Ubicacion_Id = new SelectList(db.Ubicacion, "Codigo_Id", "Direccion", entidad.Ubicacion_Id);
            return View(entidad);
        }

        // GET: Entidads/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            ViewBag.Entidad_Padre = new SelectList(db.Entidad, "Codigo_Id", "Nombre", entidad.Entidad_Padre);
            ViewBag.Ubicacion_Id = new SelectList(db.Ubicacion, "Codigo_Id", "Direccion", entidad.Ubicacion_Id);
            return View(entidad);
        }

        // POST: Entidads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo_Id,Nit,Nombre,CodigoEntidad,CodigoDane,FiniFiscal,FfinFiscal,Entidad_Padre,Ubicacion_Id,Created_At,Updated_At")] Entidad entidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Entidad_Padre = new SelectList(db.Entidad, "Codigo_Id", "Nombre", entidad.Entidad_Padre);
            ViewBag.Ubicacion_Id = new SelectList(db.Ubicacion, "Codigo_Id", "Direccion", entidad.Ubicacion_Id);
            return View(entidad);
        }

        // GET: Entidads/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidad entidad = db.Entidad.Find(id);
            if (entidad == null)
            {
                return HttpNotFound();
            }
            return View(entidad);
        }

        // POST: Entidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Entidad entidad = db.Entidad.Find(id);
            db.Entidad.Remove(entidad);
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
