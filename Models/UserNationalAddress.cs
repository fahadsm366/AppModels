using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserNationalAddress
    {
        [Key, DisplayName("Residence Number"), MaxLength(450)]
        public string User_ID { get; set; }
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
        public User User { get; set; }

    }
}
