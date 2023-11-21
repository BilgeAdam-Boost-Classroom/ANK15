using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi_bilgisi
{
    internal class Ogrenci : Kisi
    {
        public string Bolum { get; set; }
        public List<string> Dersler { get; set;}=new List<string>();
        public Ogrenci(string ad,string soyad):base(ad, soyad)
        {

        } 
        public void DersEkle(string dersler)
        {
            Dersler.Add(dersler);
        }
        
    }
}
