using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisanlar_ödev
{
    internal class Calisan
    {
        public Calisan(string ad, string soyad, string birim, DateTime gorevBaslamaTarihi, string sicilNo)
        {
            Ad = ad;
            Soyad = soyad;
            Birim = birim;
            GorevBaslamaTarihi = gorevBaslamaTarihi;
            this.sicilNo = sicilNo;
        }



        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Birim { get; set; }
        public DateTime GorevBaslamaTarihi { get; set; }

        private string _sicilNo;
        public string sicilNo
        {
            get { return _sicilNo; }
            set
            {
                if (sicilNosu(value))
                {
                    _sicilNo = value;
                }
                else
                {
                    _sicilNo = "****";
                    Console.WriteLine("Geçersiz Sicil Numarası");
                }
            }
        }
        public bool sicilNosu(string sicilNo)
        {
            if (sicilNo.Length == 4 && (sicilNo[0] == 'A' || sicilNo[0] == 'B'))
            {
                string bolumString = sicilNo.Substring(1, 3);
                if (int.TryParse(bolumString, out int bolum) && bolum >= 100 && bolum <= 999)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
