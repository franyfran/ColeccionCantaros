using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Library
{
    public class CantaroManager : IDisposable
    {
        private CantarosContext db;

        public CantaroManager()
        {
            db = new CantarosContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public int Insert(Cantaro cantaro)
        {
            db.Cantaros.Add(cantaro);
            return db.SaveChanges();
        }
    }
}