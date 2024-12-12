using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Investment
    {
       
        public string Id { get; set; }
        [Key, DisplayName("Facility Number"), MaxLength(450)]
        public string FacilityNumber { get; set; }
        [DisplayName("license Number")]
        public string licenseNumber { get; set; }
        [DisplayName("license Type")]
        public string licenseType { get; set; }
        [Required, DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required, DisplayName("Expiry Date")]
        public DateTime Expirydate { get; set; }
        [Required, DisplayName("Investor Number")]
        public string InvestorNum { get; set; }
        public string? FilePath { get; set; }

        public string LegalEntity {  get; set; }

        public ICollection<OwnerInvestment>? OwnersInvestment { get; set; }

    }
}
