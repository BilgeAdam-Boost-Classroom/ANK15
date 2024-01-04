using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptApp.Models.Abstract
{
    public interface IDers : IBaseEntity
    {
        public string Name { get; set; }
        public string Kredi { get; set; }
    }
}
