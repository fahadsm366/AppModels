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
        public string RequestID { get; set; } = Guid.NewGuid().ToString();
        public string ID { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MyProperty { get; set; }

    }
}
