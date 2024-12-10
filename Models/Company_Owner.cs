using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company_Owner
    {
        public string? Id { get; set; }
        [Key, DisplayName("Residence Number"), MaxLength(450), RegularExpression(@"[0-9]", ErrorMessage = "Residence Number must contain only numbers")]
        public string IdResidence { get; set; }
        [Required, Length(5, 25)]
        public string Name { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required, MaxLength(50)]
        public string Nationality { get; set; }
        [Required, MaxLength(10), AllowedValues("Male", "Female", "male", "female"), DeniedValues("shemale")]
        public string Gender { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        [RegularExpression(@"[0-9]", ErrorMessage = "Phone must contain only numbers")]
        public string Phone { get; set; }
        [DisplayName("User Is Deleted")]
        public bool IsDeleted { get; set; } = false;
        [DisplayName("User Is Investor")]
        public bool IsInvestor { get; set; } = false;
        [ValidateNever]
        public Residence? Residence { get; set; }
        [ValidateNever]
        public Passport? Passport { get; set; }
        [DisplayName("Peraonal Photo File Path")]
        public string? ImageFilePath { get; set; }
        [ValidateNever]
        public UserNationalAddress? UserAddress { get; set; }
        [ValidateNever]
        public ICollection<Company_Owner>? Company_Owners { get; set; } 
        [ValidateNever]
        public ICollection<Company_Manager>? Company_Managers { get; set; } 
        [ValidateNever]
        public ICollection<Company_Investment>? Company_Investments { get; set; }
    }
}
