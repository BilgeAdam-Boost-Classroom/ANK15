using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
   
    public class Danisman
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
        [NotMapped]
        public string NameSurname => $"{Name} {Surname}";
    }
}
