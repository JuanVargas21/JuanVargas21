using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anun.SHARED.Entities
{
    public class Empleado
    {
        public int Id { get; set; }

        [Display(Name = "nombre")]
        [Required(ErrorMessage = " requerido")]
        [MaxLength(225, ErrorMessage = " el nombre solo puede tener hasta 225 caracteres")]
        public string Nombrecompleto { get; set; }

        [Display(Name = "cargo")]
        [Required(ErrorMessage = " requerido")]
        [MaxLength(100, ErrorMessage = " el cargo solo puede tener hasta 100 caracteres")]
        public string cargo { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(100, ErrorMessage = " el telefono solo puede tener hasta 100 caracteres")]
        public string telefono { get; set; }

        [Display(Name = "email")]
        [MaxLength(225, ErrorMessage = " el email solo puede tener hasta 225 caracteres")]
        public string email { get; set; }
        public ICollection<AnuncioEmpleado> AnuncioEmpleados { get; set; }
    }
}
