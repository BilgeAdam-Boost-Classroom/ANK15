using BurgerApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Entity.Solids
{
    public class Order : IOrder
    {
        public Menu Menu { get; set ; } 
        public int Count { get; set; }
        public void EkstraMalzemePriace(Menu menu)
        {
            Menu = menu;
            
        }
    }
}
