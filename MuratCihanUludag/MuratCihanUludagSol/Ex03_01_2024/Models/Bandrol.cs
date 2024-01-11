using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class Bandrol
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public Kitap Kitap { get; set; }
    }
}
