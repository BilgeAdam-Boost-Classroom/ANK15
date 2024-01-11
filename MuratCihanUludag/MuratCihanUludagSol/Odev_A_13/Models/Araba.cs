using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_13.Models
{
    public class Araba
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PlakaId { get; set; }
        public virtual Plaka Plaka { get; set; }
        public int PersonId { get; set; }
        public   Person Person { get; set; }
        public ICollection<Engineer> Engineers { get; set; }
    }
}
