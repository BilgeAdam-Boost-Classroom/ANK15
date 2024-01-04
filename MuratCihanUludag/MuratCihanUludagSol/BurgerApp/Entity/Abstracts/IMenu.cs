using BurgerApp.Entity.Enums;
using BurgerApp.Entity.Solids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Entity.Abstracts
{
    public interface IMenu
    {
        
        public string Name { get; init; }
        public double Priace { get; }
        public MenuSize Size { get; set; }
        
    }
}
