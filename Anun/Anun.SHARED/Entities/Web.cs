using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anun.SHARED.Entities
{
    public class Web
    {
        public int Id { get; set; }
        [Display(Name = " url")]
        [Required(ErrorMessage = " campo requerido")]
        public string Url { get; set; }

        [Display(Name = "nombre")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(15, ErrorMessage = " el nombre puede tener hasta 15 caracteres ")]
        public string Nombre { get; set; }

        [Display(Name = "Tema")]
        [Required(ErrorMessage = " campo requerido")]
        [MaxLength(20, ErrorMessage = " el tema puede tener hasta 20 caracteres ")]
        public string Tema { get; set; }
        public ICollection<AnuncioPagina> AnuncioPagina { get; set; }
    }
}
