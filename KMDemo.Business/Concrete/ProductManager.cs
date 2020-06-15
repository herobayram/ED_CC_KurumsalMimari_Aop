using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using KMDemo.Entities.Concrete; 
using KMDemo.DataAccess.Abstract;
using KMDemo.Business.Abstract;
using System.Net.Http.Headers;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.Aspects.Logging;

namespace KMDemo.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; // referans tipidir. gönderilen class ın adresini tutar.böylece bağımlılığı çözer.
       
        //...AOP....
        private ILogger _logger;
        private ICache _cache;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //reflektion form -- Aop uygunluğu için Core a fonks olarak geçirdik.
        //public ProductManager(IProductDal productDal, ILogger logger, ICache cache)
        //{
        //    _productDal = productDal;
        //    _logger = logger;
        //    _cache = cache;
        //}

        [LogAspect]   //PostSharp ile
        public List<Product> GetAll()
        {
            //////iş kodları.... -- aop yaklaşımı ile çözmeye çalışıyoruz.PostSharp ile
            ////_logger.Log();
            ////_cache.Cache(); 

            //EfProductDal efProductDal = new EfProductDal(); //BAĞIMLI 
            return _productDal.GetAll();

        }
    }
}
