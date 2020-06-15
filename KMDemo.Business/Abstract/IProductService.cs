using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using KMDemo.Entities.Concrete;
 
namespace KMDemo.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
