using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Abstarct
{
    internal interface IBaseService<T> where T : class, IEntity
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();

    }
}
