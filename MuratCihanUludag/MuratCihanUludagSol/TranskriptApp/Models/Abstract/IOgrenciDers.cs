using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Classes;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Models.Abstract
{
    public interface IOgrenciDers : IBaseEntity
    {
        public Ogrenci Ogrenci { get; set; }
        public Donem Donem { get; set; }
        public Ders Ders { get; set; }
        public HarfNot HarfNot { get; set; }
    }
}
