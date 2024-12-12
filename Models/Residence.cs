using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Residence
    {

        public string RequestID { get; set; } = Guid.NewGuid().ToString();
        [Key, DisplayName("Residence Number"), MaxLength(450)]
        public string Id { get; set; }
        [DisplayName("Residence Number"), MaxLength(450)]
        public string IdResidence { get; set; }
        [DisplayName("Residence Copy Number"), MaxLength(2)]
        public string IdCopyNum { get; set; }
        [Required, DisplayName("Place Of Issue")]
        public string PlaceOfIssue { get; set; }
        [Required, DisplayName("Residence Type")]
        public string Type { get; set; }
        [Required, DisplayName("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }
        [Required, DisplayName("Expiry Date")]
        public DateTime Expirydate { get; set; }
        [Required, DisplayName("Employer Name")]
        public string EmployerName { get; set; }
        [Required, DisplayName("Occupation")]
        public string Occupation { get; set; }
        [Required, DisplayName("Religion")]
        public string Religion { get; set; }
        [DisplayName("Residence File Path")]
        public string? FilePath { get; set; }
    }
}
