using System;
using System.Collections.Generic;

namespace UniversiteDBUygulama.Models
{
    public partial class Danismanlar
    {
        public Danismanlar()
        {
            Ogrencilers = new HashSet<Ogrenciler>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;

        public virtual ICollection<Ogrenciler> Ogrencilers { get; set; }
    }
}
