using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using ColeccionCantaros.Models;

namespace ColeccionCantaros.DAL
{
    public class CantarosContext : DbContext
    {
        public CantarosContext() : base("CantarosConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comunidad> Comunidades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Alfarero> Alfareros { get; set; }
        public DbSet<Cantaro> Cantaros { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
    }
}