using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Alfarero
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int ProvinciaId { get; set; }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set; }

        public ICollection<Cantaro> Cantaros { get; set; }
    }
}