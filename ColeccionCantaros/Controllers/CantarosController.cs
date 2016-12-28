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
        private CantaroManager cantaroManager = new CantaroManager();

        // GET: Cantaros
        public ActionResult Index()
        {
            return View(cantaroManager.GetAll());
        }

        // GET: Cantaros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cantaro cantaro = cantaroManager.GetById(id.Value); //Cuando int? id es un objeto no un primitivo, un primitivo nunca se puede comparar con null
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
                
                cantaroManager.Insert(cantaro);
                
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
            Cantaro cantaro = cantaroManager.GetById(id.Value); //Cuando int? id es un objeto no un primitivo, un primitivo nunca se puede comparar con null
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
                cantaroManager.Update(cantaro);
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
            Cantaro cantaro = cantaroManager.GetById(id.Value); //Cuando int? id es un objeto no un primitivo, un primitivo nunca se puede comparar con null
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
            cantaroManager.DeleteById(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                cantaroManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
