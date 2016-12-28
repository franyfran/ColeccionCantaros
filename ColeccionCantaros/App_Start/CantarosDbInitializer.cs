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
                AddComunidades(context);
                AddProvincias(context);
                AddDatosPrueba(context);
            }
            catch (Exception)
            {

            }
            base.Seed(context);
        }

        private void AddDatosPrueba(CantarosContext context)
        {

            // Crear objeto alfarero de prueba
            Alfarero a = new Alfarero()
            {
                Id = 1,
                Nombre = "Pepe",
                Apellido = "De la Bota",
                ProvinciaId = 30
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

            context.SaveChanges();
        }

        private void AddProvincias(CantarosContext context)
        {
            //Provincias
            context.Provincias.Add(new Provincia()
            {
                Id = 04,
                ComunidadId = 01,
                NombreProvincia = "Almería"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 11,
                ComunidadId = 01,
                NombreProvincia = "Cádiz"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 14,
                ComunidadId = 01,
                NombreProvincia = "Córdoba"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 18,
                ComunidadId = 01,
                NombreProvincia = "Granada"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 21,
                ComunidadId = 01,
                NombreProvincia = "Huelva"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 23,
                ComunidadId = 01,
                NombreProvincia = "Jaén"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 29,
                ComunidadId = 01,
                NombreProvincia = "Málaga"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 22,
                ComunidadId = 02,
                NombreProvincia = "Huesca"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 44,
                ComunidadId = 02,
                NombreProvincia = "Teruel"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 50,
                ComunidadId = 02,
                NombreProvincia = "Zaragoza"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 33,
                ComunidadId = 03,
                NombreProvincia = "Asturias"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 07,
                ComunidadId = 04,
                NombreProvincia = "Islas baleares"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 35,
                ComunidadId = 05,
                NombreProvincia = "Las Palmas"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 38,
                ComunidadId = 05,
                NombreProvincia = "Santa Cruz de Tenerife"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 39,
                ComunidadId = 06,
                NombreProvincia = "Cantabria"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 05,
                ComunidadId = 07,
                NombreProvincia = "Ávila"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 09,
                ComunidadId = 07,
                NombreProvincia = "Burgos"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 24,
                ComunidadId = 07,
                NombreProvincia = "	León"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 34,
                ComunidadId = 07,
                NombreProvincia = "Palencia"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 37,
                ComunidadId = 07,
                NombreProvincia = "Salamanca"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 40,
                ComunidadId = 07,
                NombreProvincia = "Segovia"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 42,
                ComunidadId = 07,
                NombreProvincia = "Soria"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 47,
                ComunidadId = 07,
                NombreProvincia = "Valladolid"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 49,
                ComunidadId = 07,
                NombreProvincia = "Zamora"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 02,
                ComunidadId = 08,
                NombreProvincia = "Albacete"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 13,
                ComunidadId = 08,
                NombreProvincia = "Ciudad Real"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 16,
                ComunidadId = 08,
                NombreProvincia = "Cuenca"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 19,
                ComunidadId = 08,
                NombreProvincia = "Guadalajara"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 45,
                ComunidadId = 08,
                NombreProvincia = "Toledo"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 08,
                ComunidadId = 09,
                NombreProvincia = "Barcelona"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 17,
                ComunidadId = 09,
                NombreProvincia = "Gerona"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 25,
                ComunidadId = 09,
                NombreProvincia = "Lérida"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 43,
                ComunidadId = 09,
                NombreProvincia = "Tarragona"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 03,
                ComunidadId = 10,
                NombreProvincia = "Alicante"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 12,
                ComunidadId = 10,
                NombreProvincia = "Castellón de la Plana"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 46,
                ComunidadId = 10,
                NombreProvincia = "Valencia"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 06,
                ComunidadId = 11,
                NombreProvincia = "Badajoz"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 10,
                ComunidadId = 11,
                NombreProvincia = "Cáceres"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 15,
                ComunidadId = 12,
                NombreProvincia = "A Coruña"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 27,
                ComunidadId = 12,
                NombreProvincia = "Lugo"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 32,
                ComunidadId = 12,
                NombreProvincia = "Ourense"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 36,
                ComunidadId = 12,
                NombreProvincia = "Pontevedra"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 28,
                ComunidadId = 13,
                NombreProvincia = "Madrid"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 31,
                ComunidadId = 15,
                NombreProvincia = "Navarra"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 01,
                ComunidadId = 16,
                NombreProvincia = "Álaba"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 48,
                ComunidadId = 16,
                NombreProvincia = "Bizkaia"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 20,
                ComunidadId = 16,
                NombreProvincia = "Gipuzkoa"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 26,
                ComunidadId = 17,
                NombreProvincia = "La Rioja"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 51,
                ComunidadId = 18,
                NombreProvincia = "Ceuta"
            });

            context.Provincias.Add(new Provincia()
            {
                Id = 52,
                ComunidadId = 19,
                NombreProvincia = "Melilla"
            });


            context.Provincias.Add(new Provincia()
            {
                Id = 30,
                ComunidadId = 14,
                NombreProvincia = "Murcia"
            });

            context.SaveChanges();
        }

        private void AddComunidades(CantarosContext context)
        {
            //Comunidades Autonomas
            context.Comunidades.Add(new Comunidad()
            {
                Id = 01,
                NombreComunidad = "Andalucía"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 02,
                NombreComunidad = "Aragón"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 03,
                NombreComunidad = "Principado de Asturias"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 04,
                NombreComunidad = "Islas Baleares"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 05,
                NombreComunidad = "Islas Canarias"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 06,
                NombreComunidad = "Cantabria"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 07,
                NombreComunidad = "Castilla y León"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 08,
                NombreComunidad = "Castilla La Mancha"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 09,
                NombreComunidad = "Cataluña"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 10,
                NombreComunidad = "Comunidad Valenciana"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 11,
                NombreComunidad = "Extremadura"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 12,
                NombreComunidad = "Galicia"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 13,
                NombreComunidad = "Comunidad de Madrid"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 14,
                NombreComunidad = "Región de Murcia"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 15,
                NombreComunidad = "Comunidad Foral de Navarra"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 16,
                NombreComunidad = "Pais Vasco"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 17,
                NombreComunidad = "La Rioja"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 18,
                NombreComunidad = "Ceuta (Ciudad Autónoma)"
            });

            context.Comunidades.Add(new Comunidad()
            {
                Id = 19,
                NombreComunidad = "Melilla (Ciudad Autónoma)"
            });

            context.SaveChanges();
        }
    }
}