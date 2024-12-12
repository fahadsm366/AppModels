using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Residence
    {

        public string RequestID { get; set; } = Guid.NewGuid().ToString();
        public string ID { get; set; }  = string.Empty;
    }
}
