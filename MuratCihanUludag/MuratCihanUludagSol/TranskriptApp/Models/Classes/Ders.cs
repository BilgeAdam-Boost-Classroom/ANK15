using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;

namespace TranskriptApp.Models.Classes
{
    public class Ders : BaseEntity, IDers
    {
        public string Name { get; set; }
        public string Kredi { get; set; }  
    }
}
