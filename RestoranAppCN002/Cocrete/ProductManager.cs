using RestoranAppCN002.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Cocrete
{
    internal class ProductManager(ICheckRoleService checkRoleService, User user) : AbstarctProductManager
    {
        private readonly ICheckRoleService _roleService = checkRoleService;
        public override void Add(Product product)
        {
            if (_roleService.CheckUserRole(user))
            {
               base.Add(product);

            }
            else
                Console.WriteLine("bu operation ucun yetkiniz yoxdu");
        }
    }
}
