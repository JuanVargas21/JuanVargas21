using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anun.SHARED.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = " el nombre es requerido")]
        [MaxLength(225, ErrorMessage = " el nombre puede tener solo 50 caracteres")]
        public string Nombrecompleto { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "la direccion es requerida")]
        [MaxLength(80, ErrorMessage = " la direccion puede tener solo 80 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(10, ErrorMessage = " el telefono solo puede tener 10 caracteres")]
        public string Telefono { get; set; }

        [Display(Name = "email")]
        [MaxLength(225, ErrorMessage = " el email solo  puede tener solo 60 caracteres")]
        public string email { get; set; }
    }
}
