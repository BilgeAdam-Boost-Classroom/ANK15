using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkKutuphane.DAL.Concrete
{
    public class YayinEvi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<kitap> kitaps { get; set; }
    }
}
