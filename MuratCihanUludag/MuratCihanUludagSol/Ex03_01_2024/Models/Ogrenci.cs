using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    [Table("Students")]
    public class Ogrenci
    {
        [Key]
        [Column("OgrenciTekilAnahatar")]
        public int OgrenciBirincilAnahtar { get; set; }
        [Column("OgrenciAd", TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [NotMapped]
        public string Aciklama { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        //Foreing Key
        [Column("DanismanYabanciAnahtar")]
        [ForeignKey("DanismanYabanciAnahtar")]
        public int DanismanYabanciAnahtar { get; set; }
        //Foreing Key
        public int DanismanId { get; set; }
        //Navigasion Property
        public virtual Diploma Diploma { get; set; }
        //Navigasion Property
        public virtual Danisman Danisman { get; set; }
        //Navigasion Property
        public ICollection<Ders> Dersler { get; set; }

        //m-m icin
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }

        [NotMapped]
        public string NameSurname => $"{Name} {Surname}";
        public int SubeYabanciAnahtar { get; set; }
        public Sube Sube { get; set; }
        public int KarneId { get; set; }  
        public Transcript Transcript { get; set; }
    }
}
