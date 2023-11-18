using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_2
{
    internal class Calisan
    {
        private string sicilNo;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Birim { get; set; }
        public string SicilNo 
        {
            get { return sicilNo; } 
            set { sicilNo = ValidateSicilNo(value); } 
        }
        public DateTime GoreveBaslamaTarihi { get; set; }
        public Calisan(string ad, string soyad, string birim, string sicilNo, DateTime goreveBaslamaTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            Birim = birim;
            SicilNo = sicilNo;
            GoreveBaslamaTarihi = goreveBaslamaTarihi;
        }
        private string ValidateSicilNo(string value)
        {
            if(value.Length == 4 && (value.StartsWith("A") || value.StartsWith("B")))
            {
                string bolumStr = value.Substring(1);
                if(int.TryParse(bolumStr, out int bolum) && bolum >= 100 && bolum <= 999)
                {
                    return value;
                }

            }

            return "****";
        }
    }
}
