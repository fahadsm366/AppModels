using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Company_Owner
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        [Key, DisplayName("Residence Number"), MaxLength(450), RegularExpression(@"[0-9]", ErrorMessage = "Residence Number must contain only numbers")]
        public string IdResidence { get; set; }
        public string OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
        public string CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Required, DisplayName("Ownership Percentage")]
        public string OwnershipPercentage { get; set; }


        
        
    }
}
