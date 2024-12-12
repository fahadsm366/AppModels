using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company_National_Address
    {
        public string Id { get; set; } = string.Empty;
        [Key, MaxLength(450)]
        public string CR_ID { get; set; }
        public string AddressName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string CustomerAccount { get; set; }
        public string ShortAddress { get; set; }
        public string BuildingNumber { get; set; }
        public string SecondaryNumber { get; set; }
        public string PostalCode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Expirydate { get; set; }
        [ValidateNever]
        public Company Company { get; set; }
    }
}
