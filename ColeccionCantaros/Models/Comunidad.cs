using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Comunidad
    {
        [Key]
        public int Id { get; set; }
        public string NombreComunidad { get; set; }

        public ICollection<Provincia> Provincias { get; set; }
    }
}