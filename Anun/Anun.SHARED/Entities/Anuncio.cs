using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anun.SHARED.Entities
{
    public class Anuncio
    {
        public int Id { get; set; }

        [Display(Name = " Nombre")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(15, ErrorMessage = "El anuncio solo puede tener  hasta 15 caracteres")]
        public String Nombre { get; set; }

        [Display(Name = " Tipo")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(15, ErrorMessage = "El  tipo solo puede tener hasta 15")]
        public string Tipo { get; set; }

        [Display(Name = " contenido")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(100, ErrorMessage = "El contenido solo puede tener  hasta 100 caracteres")]
        public string contenido { get; set; }

        [Display(Name = " Titular")]
        [MaxLength(20, ErrorMessage = "El titular solo puede tener 20 caracteres")]
        public string Titular { get; set; }

        [Display(Name = " Nombre")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(20, ErrorMessage = "La categoria  solo puede tener 20 caracteres")]
        public string Categoria { get; set; }

        [Display(Name = " precio ")]
        [Required(ErrorMessage = " el precio es obligatorio")]
        [Range(500.000, 500000000000, ErrorMessage = " el monto debe de estar entre 500.000  y 100.000.000.000 pesos colombianos")]
        public string precio { get; set; }
    }
}
