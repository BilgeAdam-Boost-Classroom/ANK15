using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi_bilgisi
{
    internal class Akademisyen : Kisi
    {
        public List<string> Makaleler { get; set; } = new List<string>();

        public Akademisyen(string ad,string soyad):base(ad, soyad) 
        {
        }
        public void makaleEkle(string makale)
        {
            Makaleler.Add(makale);
        }
    }

    
}
