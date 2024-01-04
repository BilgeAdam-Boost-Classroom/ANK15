using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Models.Classes
{
    public class Ogrenci:BaseEntity, IOgrenci
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Number { get; set; }

    }
}
