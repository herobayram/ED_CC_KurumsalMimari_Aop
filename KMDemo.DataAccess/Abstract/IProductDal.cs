﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using KMDemo.Entities.Concrete;


namespace KMDemo.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}