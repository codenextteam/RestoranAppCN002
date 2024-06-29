using RestoranAppCN002.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Abstarct
{
    internal abstract class AbstractCategoryManager : ICategoryService
    {
        public virtual void Add(Category category)
        {
            Console.WriteLine($"{category.CategoryName} adli category elave olundu");
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
