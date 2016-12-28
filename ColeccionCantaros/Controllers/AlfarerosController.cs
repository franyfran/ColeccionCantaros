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
        private AlfareroManager alfareroManager = new AlfareroManager();

        // GET: Alfareros
        public ActionResult Index()
        {
                return View(alfareroManager.GetAll());
        }

        // GET: Alfareros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alfarero alfarero = alfareroManager.GetById(id.Value); //Cuando int? id es un objeto no un primitivo, un primitivo nunca se puede comparar con null
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
                alfareroManager.Insert(alfarero);
                
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
            Alfarero alfarero = alfareroManager.GetById(id.Value); //Cuando int? id es un objeto no un primitivo, un primitivo nunca se puede comparar con null
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
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,ProvinciaId")] Alfarero alfarero)
        {
            if (ModelState.IsValid)
            {
                alfareroManager.Update(alfarero);
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
            Alfarero alfarero = alfareroManager.GetById(id.Value);
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
            alfareroManager.DeleteById(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                alfareroManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
