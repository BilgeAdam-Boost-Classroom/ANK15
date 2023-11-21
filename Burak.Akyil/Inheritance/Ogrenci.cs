using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogrenci : Kisi
    {
        public Ogrenci()
        {
            Dersler = new List<string>();
        }
        public string Bolum { get; set; }
        public List<string> Dersler { get; set; }

        public void DersEkle(string ders)
        {
            Dersler.Add(ders);
        }
    }
}
