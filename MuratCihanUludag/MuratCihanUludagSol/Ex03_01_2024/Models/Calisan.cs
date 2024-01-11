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
    [Index("SicilNo", IsUnique = true)]
    [Table("Personnel")]
    public class Calisan
    {
        [Key]
        public int CalisanPrimaryKey { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
      
        public string SicilNo { get; set; }
    }
}
