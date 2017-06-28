using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PCMS.Models
{
    public class Admin
    {
        public int ID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "El nombre de usuario debe tener al menos {2} y como maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre de Usuario")]
        public string Usr { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} y como maximo {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }

    }
}
