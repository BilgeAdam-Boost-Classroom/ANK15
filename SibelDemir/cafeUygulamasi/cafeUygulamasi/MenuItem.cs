using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class MenuItem
    {
        public MenuItem(string name, decimal price, TimeSpan prepTime)
        {
            Name = name;
            Price = price;
            PrepTime = prepTime;
        }
        public string Name { get; set; }
        public decimal Price { get; }
        public TimeSpan PrepTime { get; }
    }
}
