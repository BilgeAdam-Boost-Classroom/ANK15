using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class IdariPersonel : Kisi
    {
        public IdariPersonel(string ad, string soyad) : base(ad, soyad)
        {

        }
        public string Birimi { get; set; }
    }
}
