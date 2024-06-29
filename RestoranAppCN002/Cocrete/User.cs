using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Cocrete
{
    internal class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
    }
}
