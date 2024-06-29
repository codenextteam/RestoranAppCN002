using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Cocrete
{
    internal class Order : BaseEntity
    {
        public int HallTableId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
