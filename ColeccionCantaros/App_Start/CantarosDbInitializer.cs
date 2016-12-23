using ColeccionCantaros.DAL;
using ColeccionCantaros.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.App_Start
{
    public class CantarosDbInitializer : DropCreateDatabaseIfModelChanges<CantarosContext>
    {
        protected override void Seed(CantarosContext context)
        {
            try
            {
                Comunidad c = new Comunidad()
                {
                    Id = 1,
                    NombreComunidad = "Región de Murcia" 
                };
                context.Comunidades.Add(c);

                Provincia p = new Provincia()
                {
                    Id = 1,
                    ComunidadId = 1,
                    NombreProvincia = "Murcia"
                };
                context.Provincias.Add(p);

                // Crear objeto alfarero de prueba
                Alfarero a = new Alfarero()
                {
                    Id = 1,
                    Nombre = "Pepe",
                    Apellido = "De la Bota",
                    ProvinciaId = 1
                };

                // Insertar alfarero en BBDD
                context.Alfareros.Add(a);
                context.SaveChanges(); // Devuelve nº de filas modificadas
            } catch (Exception)
            {

            }
            base.Seed(context);
        }
    }
}