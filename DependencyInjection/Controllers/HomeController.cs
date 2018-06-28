using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //sınıfdan oluşturduğumuz bir nesneye bağımlı olmamak ki bu şekilde yapacağımız bir değişikliklerde örneğin entityframeworkden adoya geçmemizde ya da ilerleyen zamanlarda başka bir yapıya biz bu yapıyı tamamen değiştirmek yerine bir çok yerde kod değiştirmemiz gerekiyor. Bu sebepten dolayı bir sınıfa bağlı olmamamız gerekiyor.

        //Bu durumda bir interface ile bağımlılığı kaldırmamız gerekiyor. AdoProduct ve EfProdut repository oluşturduğumuz IProductRepository sınıfından türetiyoruz.

        //Dışarıdan aldığımız ctorda sanal bir interface ile karşılıyoruz ve bundan sonraki bölümlerde bir değişiklik yaptığımızda sadece bulunduğu class da kodlarımı düzenlememiz yetiyor.


        private readonly IProductRepository _productRepository;
        //EfProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            // productRepository = new EfProductRepository();
        }

        public IActionResult Index()
        {
            return View(_productRepository.GetList());
        }
        public IActionResult Get()
        {
            return View(_productRepository.Get());
        }
    }
}