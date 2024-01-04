using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;

namespace TranskriptApp.Models.Classes
{
    public class Donem : BaseEntity, IDonem
    {
        public string Name { get; set; }
    }
}
