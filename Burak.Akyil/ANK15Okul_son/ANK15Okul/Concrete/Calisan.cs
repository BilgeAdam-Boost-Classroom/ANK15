using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ANK15Okul.Concrete
{
    [Index("sicilNo",IsUnique = true)]
    [Table("Personal")]
    public class Calisan
    {
        [Key]
        public int CalisanPrimaryKey { get; set; }
        public string sicilNo { get; set; }
    }
}
