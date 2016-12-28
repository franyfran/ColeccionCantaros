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

                // Crear objeto cantaro de prueba
                Cantaro ca = new Cantaro()
                {
                    Id = 1,
                    Codigo = 00001,
                    NombrePieza = "Cantaro",
                    FechaCompra = new DateTime(2005, 8, 12),
                    Precio = 150,
                    DiamBase = 3,
                    DiamBoca = 3,
                    CircMaxima = 3,
                    Altura = 3,
                    LongCuello = 3,
                    LongAsa = 3,
                    AnchoAsa = 3,
                    LongPitorro = 3,
                    Base = "av",
                    FormaCuerpo = "av",
                    Asa = "av",
                    AsaNace = "av",
                    AsaArranque = "av",
                    AsaInferior = "av",
                    AsaPegado = "av",
                    AsaForma = "av",
                    Cuello = "av",
                    Boca = "av",
                    Labio = "av",
                    Pitorro = "av",
                    Peso = 23,
                    Paredes = "av",
                    Textura = "av",
                    Color = "av",
                    Vidriado = "av",
                    Decoracion = "av",
                    Tapadera = "av",
                    AlfareroId = 1
                };

                // Insertar cantaro en BBDD
                context.Cantaros.Add(ca);

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