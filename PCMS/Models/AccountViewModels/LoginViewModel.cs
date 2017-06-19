using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCMS.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "El nombre de usuario debe tener al menos {2} y como maximo {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre de Usuario")]
        public string Usr { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Display(Name = "Recordar usuario en esta computadora?")]
        public bool RememberMe { get; set; }
    }
}
