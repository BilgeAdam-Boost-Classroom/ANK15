using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsuleme
{
    public class Calisan
    {
        public Calisan(string _ad,string _soyad ,string _birim ,string sicilNo,DateTime _gorevebaslamatarihi)
        {
                Ad = _ad;
            Soyad = _soyad;
            Birim= _birim;
            SicilNo = sicilNo;
            GoreveBaslamaTarihi= _gorevebaslamatarihi;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Birim { get; set; }
        public string SicilNo {
            get {; }
            set {
                

                ; }
        
        }
        public DateTime GoreveBaslamaTarihi { get; set; }
   

    }
}
