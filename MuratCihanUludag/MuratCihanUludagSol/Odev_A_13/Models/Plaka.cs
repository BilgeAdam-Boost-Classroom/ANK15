using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_13.Models
{
    public class Plaka
    {
        [Key]
        public int Id { get; set; }
        public string PlakaNo { get; set; }
        public  Araba Araba { get; set; }
    }
}
