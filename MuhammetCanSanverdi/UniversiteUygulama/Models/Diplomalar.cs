using System;
using System.Collections.Generic;

namespace UniversiteUygulama.Models
{
    public partial class Diplomalar
    {
        public int Id { get; set; }
        public int No { get; set; }
        public DateTime Tarih { get; set; }

        public virtual Ogrenciler? Ogrenciler { get; set; }
        public override string ToString()
        {
            return No + "-" + Tarih.ToString("dd-mm-yyyy");
        }
    }
}
