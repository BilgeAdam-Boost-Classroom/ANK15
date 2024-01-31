using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class YazarKitap
    {
        public int Id { get; set; }
        public int Author { get; set; }
        public int Book { get; set; }
        public Yazar Yazar { get; set; }
        public Kitap Kitap { get; set; }

    }
}
