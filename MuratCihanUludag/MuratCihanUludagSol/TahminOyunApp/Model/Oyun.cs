using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunApp.Model
{
    public class Oyun
    {
        public int TutulanSayi { get; set; } = new Random().Next(0,1001);
        public DateTime BilinmeAni { get; set; }    
        public bool Durum { get; set; }
        public int TahminSayisi { get; set; }   
    }
}
