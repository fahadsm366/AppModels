using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum CompanyType
    {
        none = 0,
        LocalCompanyOneOwner = 1,
        LocalCompanyMultiOwner = 2,
        ForeignCompanyOneOwner = 3,
        ForeignCompanyMultiOwner = 4,
        MixedCompanyMultiOwner = 5,
        Establishment = 6
    }
}
