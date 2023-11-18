using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsuleme
{
    public class Calisan
    {
        public Calisan(string _ad, string _soyad, string _birim, string sicilNo )
        {
            Ad = _ad;
            Soyad = _soyad;
            Birim = _birim;
            SicilNo = sicilNo;
            
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Birim { get; set; }
        private string _sicilNo;
        public string SicilNo
        {
            get { return this._sicilNo; }
            set
            {
                if (value.Length == 4 && (value.StartsWith("A") || value.StartsWith("B")) &&  Convert.ToInt32(value.Substring(1,3))>111 && Convert.ToInt32(value.Substring(1, 3)) <999)
                {
                  this. _sicilNo = value;
                }
                else
                {
                    this._sicilNo="****";
                }

            }

        }
        


    }
}
