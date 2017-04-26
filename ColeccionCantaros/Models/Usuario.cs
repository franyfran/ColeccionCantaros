using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ColeccionCantaros.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere un correo electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required, Compare("Password", ErrorMessage = "Debe repetir la contraseña")]
        public string ComparePassword { get; set; }
    }
}