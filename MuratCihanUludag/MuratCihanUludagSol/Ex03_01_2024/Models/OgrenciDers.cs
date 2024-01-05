using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class OgrenciDers
    {
        [Key]
        public int Id { get; set; }
        // Ogrenci foreign key
        public int OgrenciId { get; set; }
        // Ders foreign key
        public int DersId { get; set; }
        // Ogrenci nav prop
        public Ogrenci Ogrenci { get; set; }
        // Ders nav prop
        public Ders Ders { get; set; }
        public string Not {  get; set; }    
    }
}
