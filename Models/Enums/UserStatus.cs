using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    internal enum UserStatus
    {
        none = 0,
        Pending = 1,
        Active = 2,
        blocked = 3,
        Deleted = 4
    }
}
