using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_Calisan
{
    internal class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Birim { get; set; }

        private string _SicilNo;

        public string SicilNo
        {

            get { return _SicilNo; }
            set
            {
                int.TryParse(value.Substring(1, 3), out int devam);
                if (value.Length == 4 && (value[0] == 'A' || value[0] == 'B') && (devam >= 100 && devam <= 999))
                {

                    _SicilNo = value;

                }
                else
                {
                    _SicilNo = "****";
                }
            }
        }

        public DateTime GoreveBaslamaTarihi { get; set; }
        public Calisan(string ad, string soyad, string birim, string sicilNo, DateTime goreveBaslamaTarihi)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Birim = birim;
            this.SicilNo=sicilNo;
            this.GoreveBaslamaTarihi = goreveBaslamaTarihi;

        }
    }
}
