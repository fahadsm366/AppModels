using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Passport
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        [MaxLength(10)]
        public string PassID { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MyProperty { get; set; }

    }
}
