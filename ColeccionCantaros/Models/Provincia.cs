using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Provincia
    {
        [Key]
        public int Id { get; set; }
        public string NombreProvincia { get; set; }
        public int ComunidadId { get; set; }

        [ForeignKey("ComunidadId")]
        public Comunidad Comunidad { get; set; }

        public ICollection<Alfarero> Alfareros { get; set; }
    }
}