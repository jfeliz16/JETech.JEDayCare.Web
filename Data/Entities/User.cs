using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage ="El nombre es requerido")]
        [StringLength(60,ErrorMessage ="Los nombres no puede contener mas de {0} caracteres.")]
        [DisplayName("Nombres")]
        public string FirtsName { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(60, ErrorMessage = "Los apellidos no pueden contener mas de {0} caracteres.")]
        [DisplayName("Nombres")]
        public string LastName { get; set; }

        public string FullName => $"{FirtsName} {LastName}";
    }
}
