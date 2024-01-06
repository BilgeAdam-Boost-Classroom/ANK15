using System;
using System.Collections.Generic;

namespace LINQOrnekler.Models
{
    public partial class Musteriler
    {
        public Musteriler()
        {
            Hesaplars = new HashSet<Hesaplar>();
        }

        public int MusteriId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;

        public virtual ICollection<Hesaplar> Hesaplars { get; set; }
    }
}
