using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_13.Models
{
    public class Engineer
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public ICollection<Araba> Arabalar { get; set; }
    }
}
