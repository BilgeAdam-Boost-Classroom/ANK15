using System;
using System.Collections.Generic;

namespace UniversiteDBUygulama.Models
{
    public partial class Ogrenciler
    {
        public Ogrenciler()
        {
            OgrenciDerslers = new HashSet<OgrenciDersler>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Numara { get; set; } = null!;
        public int? DanismanId { get; set; }
        public int? DiplomaId { get; set; }

        public virtual Danismanlar? Danisman { get; set; }
        public virtual Diplomalar? Diploma { get; set; }
        public virtual ICollection<OgrenciDersler> OgrenciDerslers { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
