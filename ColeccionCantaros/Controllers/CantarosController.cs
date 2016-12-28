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
    public class CantarosController : Controller
    {
        private CantarosContext context = new CantarosContext();

        // GET: Cantaros
        public ActionResult Index()
        {
            return View(context.Cantaros.Include(c => c.Alfarero).ToList());
        }

        // GET: Cantaros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cantaro cantaro = context.Cantaros.Find(id);
            if (cantaro == null)
            {
                return HttpNotFound();
            }
            return View(cantaro);
        }

        // GET: Cantaros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cantaros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,NombrePieza,FechaCompra,Precio,DiamBase,DiamBoca,CircMaxima,Altura,LongCuello,LongAsa,AnchoAsa,LongPitorro,Base,FormaCuerpo,Asa,AsaNace,AsaArranque,AsaInferior,AsaPegado,AsaForma,Cuello,Boca,Labio,Pitorro,Peso,Paredes,Textura,Color,Vidriado,Decoracion,Tapadera,AlfareroId")] Cantaro cantaro)
        {
            if (ModelState.IsValid)
            {
                using (var cantaroManager = new CantaroManager())
                {
                    cantaroManager.Insert(cantaro);
                }
                return RedirectToAction("Index");
            }

            return View(cantaro);
        }

        // GET: Cantaros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cantaro cantaro = context.Cantaros.Find(id);
            if (cantaro == null)
            {
                return HttpNotFound();
            }
            return View(cantaro);
        }

        // POST: Cantaros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,NombrePieza,FechaCompra,Precio,DiamBase,DiamBoca,CircMaxima,Altura,LongCuello,LongAsa,AnchoAsa,LongPitorro,Base,FormaCuerpo,Asa,AsaNace,AsaArranque,AsaInferior,AsaPegado,AsaForma,Cuello,Boca,Labio,Pitorro,Peso,Paredes,Textura,Color,Vidriado,Decoracion,Tapadera")] Cantaro cantaro)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cantaro).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cantaro);
        }

        // GET: Cantaros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cantaro cantaro = context.Cantaros.Find(id);
            if (cantaro == null)
            {
                return HttpNotFound();
            }
            return View(cantaro);
        }

        // POST: Cantaros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Cantaro cantaro = context.Cantaros.Find(id);
            context.Cantaros.Remove(cantaro);
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
