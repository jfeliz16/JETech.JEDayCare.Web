using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.JEDayCare.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "This field {0} is requered.")]
        [EmailAddress]
        [Display(Name = "User")]
        public string Username { get;  set; }

        [Required(ErrorMessage = "This field {0} is requered.")]
        [Display(Name = "Password")]        
        [DataType(DataType.Password)]        
        public string Password { get;  set; }

        [Display(Name = "Remember Me")]        
        public bool RememberMe { get;  set; }
    }
}
