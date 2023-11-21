using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogrenci : Kisi
    {
        public Ogrenci(string ad, string soyad) : base(ad, soyad)
        {
            
        }
        public string Bolum { get; set; }
        public List<string> Dersler { get; set; } = new List<string>();

        public void DersEkle(string ders)
        {
            Dersler.Add(ders);
        }
    }
}
