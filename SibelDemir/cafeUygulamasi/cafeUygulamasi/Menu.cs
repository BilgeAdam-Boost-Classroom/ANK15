using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeUygulamasi
{
    internal class Menuu
    {
        public MenuItem this[string ItemName]
        {
            get
            {
                return menuItems.First(item=>item.Name== ItemName);
            }
        }
        public MenuItem[] menuItems { get; }

        public Menuu(params MenuItem[] items)
        {
            menuItems = items;
        }
    }
}
