using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekil.Okul
{
    internal class Ogrenci : Kisi
    {
        public string Bolum { get; set; }
        public List<string> Dersler { get; set; } = new List<string>();
        public void DersEkle(string _ders)
        {
            Dersler.Add(_ders);
        }
        public string DersGoster()
        {
            string dersListesi = ""; 
            foreach (var item in Dersler)
            {
                dersListesi += item + ",";
            }
            return dersListesi;
        }
  
    }
}
