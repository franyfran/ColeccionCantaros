using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Library
{
    public class AlfareroManager : IDisposable
    {
        public AlfareroManager()
        {
            db = new CantarosContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        private CantarosContext db;

        public int Insert(Alfarero alfarero)
        {
            db.Alfareros.Add(alfarero);
            return db.SaveChanges(); 
        }

        public IEnumerable<Alfarero> GetAll()
        {
            return db.Alfareros.ToList();
        }

        public Alfarero GetById(int id)
        {

            return db.Alfareros.FirstOrDefault(a => a.Id == id);
        }
        
        public int Update(Alfarero alfarero)
        {
            db.Entry(alfarero).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int DeleteById(int id)
        {
            Alfarero alfarero = GetById(id);
            db.Alfareros.Remove(alfarero);
            return db.SaveChanges();
        }

    }
}