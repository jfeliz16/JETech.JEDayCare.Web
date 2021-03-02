using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.JEDayCare.Web.Models.Client
{
    public class AddClientViewModel
    {
        [Display(Name = "Full Name")]
        [MaxLength(120, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string FullName { get; set; }
        
        [Display(Name = "Firts Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string FirstNameChild { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public DateTime BirthDateChild { get; set; }

        [Display(Name = "Lasts Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string LastNameChild { get; set; }

        [Display(Name = "Firts Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string FirstName { get; set; }

        [Display(Name = "Lasts Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string LastName { get; set; }

        [Display(Name = "ID Type")]
        [MaxLength(1, ErrorMessage = Global.Messages.MaxLengthVal)]        
        public int? TypeIdentityId { get; set; }

        [Display(Name = "ID")]
        [MaxLength(20, ErrorMessage = Global.Messages.MaxLengthVal)]        
        public string IdentityId { get; set; }

        [Display(Name = "Home Phone")]
        [MaxLength(10, ErrorMessage = Global.Messages.MaxLengthVal)]
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [Display(Name = "Cell Phone")]
        [MaxLength(10, ErrorMessage = Global.Messages.MaxLengthVal)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string CellPhone { get; set; }

        [Display(Name = "Contry")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Contry { get; set; }

        [Display(Name = "City")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string City { get; set; }

        [Display(Name = "State")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string State { get; set; }

        [Display(Name = "Address")]
        [MaxLength(100, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(6, ErrorMessage = Global.Messages.MaxLengthVal)]
        public int? ZipCode { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = Global.Messages.MaxLengthVal)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
