using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Cantaro
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string NombrePieza { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Precio { get; set; }
        public double DiamBase { get; set; }
        public double DiamBoca { get; set; }
        public double CircMaxima { get; set; }
        public double Altura { get; set; }
        public double LongCuello { get; set; }
        public double LongAsa { get; set; }
        public double AnchoAsa { get; set; }
        public double LongPitorro { get; set; }
        public string Base { get; set; }
        public string FormaCuerpo { get; set; }
        public string Asa { get; set; }
        public string AsaNace { get; set; }
        public string AsaArranque { get; set; }
        public string AsaInferior { get; set; } 
        public string AsaPegado { get; set; }
        public string AsaForma { get; set; }
        public string Cuello { get; set; }
        public string Boca { get; set; }
        public string Labio { get; set; }
        public string Pitorro { get; set; }
        public decimal Peso { get; set; }
        public string Paredes { get; set; }
        public string Textura { get; set; }
        public string Color { get; set; }
        public string Vidriado { get; set; }
        public string Decoracion { get; set; }
        public string Tapadera { get; set; }
        public int AlfareroId { get; set; }

        [ForeignKey("AlfareroId")]
        public Alfarero Alfarero { get; set; }
        public ICollection<Imagen> Imagenes { get; set; }
    }
}