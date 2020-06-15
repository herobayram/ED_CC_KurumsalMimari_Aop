using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Collections.Generic;

using KMDemo.Entities.Concrete;
using KMDemo.DataAccess.Abstract;

namespace KMDemo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop" },
                new Product { Id = 2 , Name = "Mouse" }
            };
        }
    }
}
