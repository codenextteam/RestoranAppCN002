using RestoranAppCN002.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Cocrete
{
    internal class UserCheckRoleManager : ICheckRoleService
    {
        enum RoleEnum
        {
            ADMIN, WAITER, CASHIER
        }
        public bool CheckUserRole(User user)
        {
            if (RoleEnum.ADMIN.ToString() == user.Role || RoleEnum.CASHIER.ToString() == user.Role)
                return true;
            else 
                return false;
        }
    }
}
