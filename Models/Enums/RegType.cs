using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    internal enum RegType
    {
        none = 0,
        MainReg = 1,
        SubReg = 2,
        ForeignCompanyOneOwner = 3,
        ForeignCompanyMultiOwner = 4,
        MixedCompanyMultiOwner = 5,
        Establishment = 6
    }
}
