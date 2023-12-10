using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class OrderItem
    {
        public MenuItem Item { get; }
        public CoffeeSize Size { get; }
        public IExtra[] Extras { get; }
        public decimal Price { get;  }
        public TimeSpan PrepTime { get; }
        public OrderItem(MenuItem ıtem, CoffeeSize size, params IExtra[] extras)
        {
            Item = ıtem;
            Size = size;
            Extras = extras;
            Price=Item.Price+(int)Size+Extras.Sum(x => x.Price);
            PrepTime=TimeSpan.FromSeconds(Item.PrepTime.TotalSeconds+(int)Size+Extras.Sum(x=>x.PrepTime.TotalSeconds));
            
        }
    }
}
