using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMDemo.Entities.Concrete
{
    public class Product : IEntity    // classları çıplak bırakmıyoruz.
    {                                 // IEntity : Core altına aldık. Tüm projelerden erişilebilmesi için
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
