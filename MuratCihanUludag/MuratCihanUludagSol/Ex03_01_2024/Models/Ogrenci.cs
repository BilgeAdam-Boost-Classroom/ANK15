using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        //Foreing Key
        public int DiplomaId { get; set; }
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
    }
}
