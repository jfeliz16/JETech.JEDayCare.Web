using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.JEDayCare.Web.Models
{
    public class AddUserViewModel
    {
        public int Id { get; set; }  

        [Display(Name = "Nombres")]
        [MaxLength(60, ErrorMessage = "El campo {0} no pueden contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(60, ErrorMessage = "El campo {0} no pueden contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        public string LastName { get; set; }
                
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength =6, ErrorMessage = "Este campo {0} es requerido.")]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Este campo {0} es requerido.")]
        [Compare("Password",ErrorMessage = "Las contraseña no coinciden.")]
        public string PasswordConfirm { get; set; }
    }
}
