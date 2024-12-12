using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company_Location
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public Company_National_Address National_Address { get; set; }
        public string? National_Address_Id { get; set; } = string.Empty;
        public Lease_Contracts Lease_Contracts { get; set; }
        public string? Lease_Contracts_Contract_Number { get; set; } = string.Empty;

    }
}
