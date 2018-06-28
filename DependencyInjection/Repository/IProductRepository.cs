using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository
{
   public interface IProductRepository
    {
        // Methodlarımızın burada tanımlıyoruz.
        Product Get();
        List<Product> GetList();
    }
}
