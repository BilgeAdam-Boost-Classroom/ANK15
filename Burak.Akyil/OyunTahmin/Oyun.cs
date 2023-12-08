using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunTahmin
{
    public class Oyun
    {
        public int TutulanSayı { get; } = new Random().Next(1, 101);
        public DateTime? BilinmeAni { get; set; }
        public bool Durum { get; set; }
        public int TahminSayisi { get; set; }
    }
}
