using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Library
{
    public class CantaroManager : IDisposable
    {
        public CantaroManager()
        {
            db = new CantarosContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        private CantarosContext db;

        public int Insert(Cantaro cantaro)
        {
            db.Cantaros.Add(cantaro);
            return db.SaveChanges();
        }

        public IEnumerable<Cantaro> GetAll()
        {
            return db.Cantaros.Include("Alfarero").ToList();
        }

        public Cantaro GetById(int id)
        {
            return db.Cantaros.FirstOrDefault(c => c.Id == id);
        }

        public int Update(Cantaro cantaro)
        {
            db.Entry(cantaro).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int DeleteById(int id)
        {
            Cantaro cantaro = GetById(id);
            db.Cantaros.Remove(cantaro);
            return db.SaveChanges();
        }
        
    }
}