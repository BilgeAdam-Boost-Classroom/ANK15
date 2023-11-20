using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_2.Class.Calisan
{
    internal class Calisan
    {
        private string _sicilNo;
        public Calisan(string ad, string soyAd, string sicilNo, DateTime baslamaTarih)
        {
            Ad = ad;
            SoyAd = soyAd;

            if (sicilNo.Length == 4 &&
                (sicilNo[0] == 'A' || sicilNo[0] == 'B') &&
                char.IsDigit(sicilNo[1]) &&
                char.IsDigit(sicilNo[2]) &&
                char.IsDigit(sicilNo[3]) &&
                int.Parse(sicilNo.Substring(1)) >= 100 &&
                int.Parse(sicilNo.Substring(1)) <= 999)
            {
                _sicilNo = sicilNo;
            }
            else
            {
                Console.WriteLine("Gecersiz giris yaptiniz !!");
                _sicilNo = "****";
            }
            GoreveBaslamTarihi = baslamaTarih;
        }
        public string Ad { get; init; }
        public string SoyAd { get; init; }
        public string SicilNo
        {
            get
            {
                return _sicilNo;
            }
            init
            {
            
                _sicilNo = value;    
            }
        }
        public DateTime GoreveBaslamTarihi { get; init; }
        public override string ToString()
        {
            return $"{Ad} {SoyAd} {SicilNo} {GoreveBaslamTarihi}";
        }
    }
}
