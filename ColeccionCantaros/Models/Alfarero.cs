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

        [Required(AllowEmptyStrings = true, ErrorMessage = "El nombre del Alfarero es obligatorio"), StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(70)]
        public string Apellido { get; set; }

        public int ProvinciaId { get; set; }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set; }

        public ICollection<Cantaro> Cantaros { get; set; }
    }
}