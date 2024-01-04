using BurgerApp.Entity.Solids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Entity.Abstracts
{
    public interface IOrder
    {
        public Menu Menu { get; set; }
        public int Count { get; set; }
    }
}
