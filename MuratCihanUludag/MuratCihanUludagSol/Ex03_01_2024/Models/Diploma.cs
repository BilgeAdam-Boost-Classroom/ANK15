using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class Diploma
    {
        public int ID { get; set; } 
        public string No { get; set; }
        public DateTime Tarih { get; set; } 
        public Ogrenci Ogrenci { get; set; }
    }
}
