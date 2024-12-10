using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum UserPermissions
    {
        none = 0,
        Owner = 1,
        Admin = 2,
        supervisor = 3,
        CompanyUser = 4,
        accountant = 5,
        ClientUser = 6
    }
}
