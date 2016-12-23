using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Imagen
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public int CantaroId { get; set; }

        [ForeignKey("CantaroId")]
        public Cantaro Cantaro { get; set; }
    }
}