using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository
{
    public class AdoProductRepository : IProductRepository
    {
        //methodların içeriğini yazıyoruz.

        public Product Get()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "Product 1"
            };
            return product;
        }

        public List<Product> GetList()
        {
            var product = new List<Product>()
            {
             new Product(){Id = 1,Name = "Product 1"},
             new Product(){Id = 2,Name = "Product 2"},
             new Product(){Id = 3,Name = "Product 3"},
             new Product(){Id = 4,Name = "Product 4"},
            };
            return product;
        }
    }
}
