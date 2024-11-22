using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anun.SHARED.Entities
{
    public class Pago
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " la fecha es obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = " monto")]
        [Required(ErrorMessage = " el monto es obligatorio")]
        [Range(1000, 500000000000, ErrorMessage = " el monto debe de estar entre 1.000  y 100.000.000.000 pesos colombianos")]
        public string monto { get; set; }
        public Cliente Cliente { get; set; }
        public Anuncio Anuncio { get; set; }
    }
}
