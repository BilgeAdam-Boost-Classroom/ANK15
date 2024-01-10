using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ANK15Okul.Concrete
{
    [Index("No",IsUnique =true)]
    public class Diploma
    {
        [Key]
        public int DiplomaBirincilAnahtar { get; set; }
        public string No { get; set; }
        public DateTime Tarih { get; set; }

        public Ogrenci Ogrenci { get; set; }

        public override string ToString()
        {
            return No;
        }
    }
}
