using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using ColeccionCantaros.Library;

namespace ColeccionCantaros.Controllers
{
    public class AlfarerosController : Controller
    {
        private CantarosContext context = new CantarosContext();

        // GET: Alfareros
        public ActionResult Index()
        {
            return View(context.Alfareros.ToList());
        }

        // GET: Alfareros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alfarero alfarero = context.Alfareros.Find(id);
            if (alfarero == null)
            {
                return HttpNotFound();
            }
            return View(alfarero);
        }

        // GET: Alfareros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alfareros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,ProvinciaId")] Alfarero alfarero)
        {
            if (ModelState.IsValid)
            {
                using (var alfareroManager = new AlfareroManager())
                {
                    alfareroManager.Insert(alfarero);
                }
                return RedirectToAction("Index");
            }

            return View(alfarero);
        }

        // GET: Alfareros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alfarero alfarero = context.Alfareros.Find(id);
            if (alfarero == null)
            {
                return HttpNotFound();
            }
            return View(alfarero);
        }

        // POST: Alfareros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido")] Alfarero alfarero)
        {
            if (ModelState.IsValid)
            {
                context.Entry(alfarero).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alfarero);
        }

        // GET: Alfareros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alfarero alfarero = context.Alfareros.Find(id);
            if (alfarero == null)
            {
                return HttpNotFound();
            }
            return View(alfarero);
        }

        // POST: Alfareros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alfarero alfarero = context.Alfareros.Find(id);
            context.Alfareros.Remove(alfarero);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
