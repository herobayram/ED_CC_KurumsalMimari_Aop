using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using KMDemo.DataAccess.Abstract;
using KMDemo.Entities.Concrete;

namespace KMDemo.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "TV" },
                new Product { Id = 2 , Name = "PC" }
            };
        }
    }
}
