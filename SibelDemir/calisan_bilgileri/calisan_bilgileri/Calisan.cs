using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisan_bilgileri
{
    internal class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public long TC { get; set;}

        public override string ToString()
        {
            return Ad+" "+Soyad+" "+Yas+" "+TC;
        }
    }
    
}
