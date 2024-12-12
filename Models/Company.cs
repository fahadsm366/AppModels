using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Models
{
    public class Company
    {
        public string Company_Id { get; set; } = Guid.NewGuid().ToString();

        [Key, DisplayName("CR Number"), MaxLength(450)]
        public string CR_Number { get; set; }
        [DisplayName("CR Identity 700")]
        public string CR_Identity { get; set; }
        [Required, MaxLength(75), MinLength(10), DisplayName("Company English Name")]
        public string CompanyEnName { get; set; }
        [Required, MaxLength(75), MinLength(10), DisplayName("Company Arabic Name")]
        public string CompanyArName { get; set; }
        [Required, MaxLength(50), DisplayName("Company Nationality")]
        public string CR_Nationality { get; set; }
        [Required, DisplayName("CR Activity")]
        public string CR_Activity { get; set; }
        [Required, DisplayName("CR Total Capital")]
        public string TotalCapital { get; set; }
        [Required, DisplayName("CR Type")]
        public string CR_Type { get; set; }
        [Required, DisplayName("CR Release Date")]
        public DateTime CR_ReleaseDate { get; set; }
        [Required, DisplayName("CR Expiry Date")]
        public DateTime CR_Expirydate { get; set; }
        [Required, DisplayName("CR City")]
        public string CR_City { get; set; }
        [Required, DisplayName("CR Master")]
        public string CR_Master { get; set; }
        [DisplayName("CR Note")]
        public string CR_Note { get; set; }
        public Company_Location Company_Location { get; set; }
        public string Company_ID { get; set; }
        [DisplayName("CR File Path")]
        public string? FilePath { get; set; }
        [ValidateNever]
        [DisplayName("CR Is Canceled")]
        public bool IsDeleted { get; set; } = false;
        [ValidateNever]
        [DisplayName("CR Status")]
        public string CR_Status { get; set; }
        [ValidateNever]
        public ICollection<Company_Owner>? ownerCompany { get; set; } = new List<Company_Owner>();
        [ValidateNever]
        public ICollection<Company_Manager>? Company_Manager { get; set; } = new List<Company_Manager>();
    }
}
