using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class YayınEvi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
