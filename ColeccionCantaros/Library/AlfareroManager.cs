using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using System;
using System.Collections.Generic;
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
    }
}