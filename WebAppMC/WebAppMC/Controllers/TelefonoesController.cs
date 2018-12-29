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
    public class TelefonoesController : Controller
    {
        private MilenioCloudEntities db = new MilenioCloudEntities();

        // GET: Telefonoes
        public ActionResult Index()
        {
            var telefono = db.Telefono.Include(t => t.Entidad);
            return View(telefono.ToList());
        }

        // GET: Telefonoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefono telefono = db.Telefono.Find(id);
            if (telefono == null)
            {
                return HttpNotFound();
            }
            return View(telefono);
        }

        // GET: Telefonoes/Create
        public ActionResult Create()
        {
            ViewBag.Entidad_Id = new SelectList(db.Entidad, "Codigo_Id", "Nombre");
            return View();
        }

        // POST: Telefonoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo_Id,Entidad_Id,Numero,Tipo,Created_At,Updated_At")] Telefono telefono)
        {
            if (ModelState.IsValid)
            {
                telefono.Codigo_Id = Guid.NewGuid();
                db.Telefono.Add(telefono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Entidad_Id = new SelectList(db.Entidad, "Codigo_Id", "Nombre", telefono.Entidad_Id);
            return View(telefono);
        }

        // GET: Telefonoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefono telefono = db.Telefono.Find(id);
            if (telefono == null)
            {
                return HttpNotFound();
            }
            ViewBag.Entidad_Id = new SelectList(db.Entidad, "Codigo_Id", "Nombre", telefono.Entidad_Id);
            return View(telefono);
        }

        // POST: Telefonoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo_Id,Entidad_Id,Numero,Tipo,Created_At,Updated_At")] Telefono telefono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telefono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Entidad_Id = new SelectList(db.Entidad, "Codigo_Id", "Nombre", telefono.Entidad_Id);
            return View(telefono);
        }

        // GET: Telefonoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Telefono telefono = db.Telefono.Find(id);
            if (telefono == null)
            {
                return HttpNotFound();
            }
            return View(telefono);
        }

        // POST: Telefonoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Telefono telefono = db.Telefono.Find(id);
            db.Telefono.Remove(telefono);
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
