using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using KMDemo.Business.Abstract;
using KMDemo.Business.Concrete;
using KMDemo.DataAccess.Concrete.EntityFramework;
using KMDemo.DataAccess.Concrete.NHibernate;

namespace KMDemo.UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProductService _productService = new ProductManager(new EfProductDal());
            //IProductService _productService =
            //    new ProductManager(new EfProductDal(), new Logger(), new CacheService());

            ///burası KÖTÜ KOD (new-leme var)--> IoC Container-lar ile çözülüyor...
            IProductService _productService = new ProductManager(new NhProductDal());

            foreach (var product in _productService.GetAll() )
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}
