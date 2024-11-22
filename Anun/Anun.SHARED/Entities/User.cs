using Anun.SHARED.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Anun.SHARED.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = " el nombre es requerido")]
        [MaxLength(225, ErrorMessage = " el nombre puede tener solo 50 caracteres")]
        public string Nombrecompleto { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo 20 caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Foto")]
        public string Photo { get; set; }

        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; } //Enum


    }
}
