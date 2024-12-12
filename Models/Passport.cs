using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Passport
    {
        public string RequestID { get; set; } = Guid.NewGuid().ToString();
        [Key, Required, MaxLength(450), DisplayName("Residence Number")]
        public string Id { get; set; }

        [Required, MaxLength(75), MinLength(10)]
        public string Name { get; set; }

        [Required, DisplayName("Release Date")]
        //[Range(typeof(DateTime), "2014-01-01", "2024-12-31", ErrorMessage = "Date must be between 2014-01-01 and 2024-12-31.")]
        public DateTime ReleaseDate { get; set; }

        [Required, DisplayName("Expiry Date")]
        //[Range(typeof(DateTime), "2014-31-01", "2034-12-31", ErrorMessage = "Date must be between 2024-03-01 and 2034-12-31.")]
        public DateTime Expirydate { get; set; }

        [Required, DisplayName("Place Of Issue")]
        public string PlaceOfIssue { get; set; }

        [Required, DisplayName("Place Of Birth")]
        public string PlaceOfBirth { get; set; }

        [Required, DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Passport File Path")]
        public string? FilePath { get; set; }

    }
}
