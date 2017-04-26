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
		
		[Required(ErrorMessage = "El número de la ficha es obligatorio")]
        public int NumeroFicha { get; set; }
		
		[Required(AllowEmptyStrings = true, ErrorMessage ="El nombre del cántaro es obligatorio"), StringLength(60)]
        public string Nombre { get; set; }
        
        [StringLength(60)]
        public string Procedencia { get; set; }

        public DateTime? Comprado { get; set; }

        [StringLength(20)]
        public string Codigo { get; set; }

        public DateTime? Fecha { get; set; }
        public decimal? Precio { get; set; }

        [StringLength(60)]
        public string Firma { get; set; }

        
        public string OtrosDatos1 { get; set; }
        public string OtrosDatos2 { get; set; }
        public double? DiametroBase { get; set; }
        public double? DiametroBoca { get; set; }
        public double? CircunferenciaMaxima { get; set; }
        public double? Altura { get; set; }
        public double? LargoCuello { get; set; }
        public double? LargoAsa { get; set; }
        public double? LargoPitorro { get; set; }

        [StringLength(50)]
        public string FormaBase { get; set; }

        [StringLength(50)]
        public string FormaCuerpo { get; set; }

        [StringLength(50)]
        public string FormaCuello { get; set; }

        [StringLength(50)]
        public string FormaBoca { get; set; }

        [StringLength(50)]
        public string FormaLabio { get; set; }

        [StringLength(50)]
        public string FormaPitorro { get; set; }

        [StringLength(50)]
        public string FormaParedes { get; set; }

        [StringLength(50)]
        public string FormaTextura { get; set; }

        [StringLength(50)]
        public string AsaNace { get; set; }

        [StringLength(50)]
        public string AsaArranque { get; set; }

        [StringLength(50)]
        public string AsaFinInferior { get; set; }

        [StringLength(50)]
        public string AsaPegado { get; set; }

        [StringLength(50)]
        public string AsaForma { get; set; }

        [StringLength(50)]
        public string Tapadera { get; set; }

        public double? TapaderaDiametro { get; set; }
        public double? TapaderaAltura { get; set; }

        [StringLength(50)]
        public string TapaderaForma { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Vidriado { get; set; }

        [StringLength(50)]
        public string Decoración { get; set; }

        [StringLength(50)]
        public string ComentarioPieza { get; set; }

        public int AlfareroId { get; set; }

        [ForeignKey("AlfareroId")]
        public Alfarero Alfarero { get; set; }
        public ICollection<Imagen> Imagenes { get; set; }
    }
}