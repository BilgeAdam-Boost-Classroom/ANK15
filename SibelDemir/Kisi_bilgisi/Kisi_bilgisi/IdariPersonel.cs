using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi_bilgisi
{
    internal class IdariPersonel:Kisi
    {
        public string Birim { get; set; }

        public IdariPersonel(string ad,string soyad):base(ad, soyad) 
        { 
        }
    }
}
