using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Residencies
    {

        public Guid ID { get; set; }  = Guid.NewGuid();
        public string RsID { get; set; }  = string.Empty;
    }
}
