using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Owner
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ArabicName { get; set; }
        public string EnglishAName { get; set; }
        public int MyProperty { get; set; }


        public Residence Residencies { get; set; }
        public string ResidenciesID { get; set; }

        public Residence Passport { get; set; }
        public string PassportID { get; set; }
    }
}
