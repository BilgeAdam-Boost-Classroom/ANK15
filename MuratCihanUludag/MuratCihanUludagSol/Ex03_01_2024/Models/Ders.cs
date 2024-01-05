using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }

        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
