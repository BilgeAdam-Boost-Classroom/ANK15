using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class Sube
    {
        [Key]
        [Column("SubeTekilAnahtar")]
        public int SubePrimaryKey { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
