using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    [Table("Students")]
    public class Ogrenci
    {
        [Column("OgrenciTekilNo")]
        [Key]
        public int OgrenciBirincilAnahtar { get; set; }

        [Column("OgrenciAd", TypeName = "nvarchar(100)")]
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Numara { get; set; }
        [NotMapped]
        public string Aciklama { get; set; }

        //Foreign Key -> Diploma sınıfının ID'si ile eşlenir.
        [ForeignKey("Diploma")]
        public int DiplomaYabanciAnahtar { get; set; }
        
        //Navigation property
        public Diploma Diploma { get; set; }

        //Foreign Key -> Danisman sinifinin ID'si ile eslenir.

        [Column("DanismanYabanciAnahtar")]
        public int DanismanId { get; set; }
        //Navigation property
        public Danisman Danisman { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; }
        public int SubeYabanciAnahtar { get; set; }
        public Sube Sube { get; set; }
        public int KarneId { get; set; }
        public Transkript Transkript { get; set; }

        public override string ToString()
        {
            return Adı + " " + Soyadı;
        }
    }
}
