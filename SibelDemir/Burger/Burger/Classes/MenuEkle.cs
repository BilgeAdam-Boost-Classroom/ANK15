using Burger.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger.Classes
{
    public class MenuEkle
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public decimal Price { get; set; }
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }

       
    }
}
