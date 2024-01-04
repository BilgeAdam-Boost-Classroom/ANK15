using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Classes;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Models.Abstract
{
    public interface IOgrenci : IBaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; } 
        public string Number { get; set; }


    }
}
