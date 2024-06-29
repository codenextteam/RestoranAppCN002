using RestoranAppCN002.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAppCN002.Abstarct
{
    internal abstract class AbstarctProductManager : IProductService
    {
        private readonly List<Product> _products;
        protected AbstarctProductManager()
        {
            _products = new List<Product>() 
            { 
                new() { Id = 1, CategoryId = 1, ProductName = "Cola", 
                    Description="Qazli icmeli su",Price=3.50 },
                   new() { Id = 2, CategoryId = 1, ProductName = "Sirab",
                    Description="Qazli icmeli su",Price=2 },
            };
        }
        public virtual void Add(Product product)
        {
            //-------
            //---------
            Console.WriteLine($"{product.ProductName} adli mehsul yarandi");
        }

        public void Delete(Product product)
        {
            Product deletedProduct = null;
            foreach (var item in _products)
            {
                if (item.Id == product.Id)
                {
                    deletedProduct = item;
                    break;
                }
               
            }
            if (deletedProduct != null)
            {
                _products.Remove(deletedProduct);
                Console.WriteLine($"{deletedProduct.ProductName} silindi");
            }
            else
            {
                Console.WriteLine("bele mehsul yoxdur");
            }

        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
