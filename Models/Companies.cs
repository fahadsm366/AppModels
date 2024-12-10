using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Companies
    {
        public Guid Company_Id { get; set; }
        public string ComReg { get; set; }
        public string Com700Num { get; set; }
        public string? MainReg700Num { get; set; }

    }
}
