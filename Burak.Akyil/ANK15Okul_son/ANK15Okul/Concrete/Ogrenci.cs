using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    [Table("Students")]
    public class Ogrenci
    {
        [Key]
        [Column("OgrenciTekilNo")]
        public int OgrenciBirincilAnahtar { get; set; }

        [Column("OgrenciAd", TypeName = "nvarchar(100)")]
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Numara { get; set; }

        [ForeignKey("Diploma")]
        public int? DiplomaYabanciAnahtar { get; set; }

        public Diploma Diploma { get; set; }

        [Column("DanismanYabanciAnahtar")]
        public int? DanismanId { get; set; }

        public Danisman Danisman { get; set; }
        
        [NotMapped]
        public string Aciklama { get; set; }

        public List<OgrenciDers> OgrenciDersler { get; set; }
        public Sube Sube { get; set; }
        public int SubeYabancıAnahtar { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    
    }
}
