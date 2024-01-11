using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_01_2024.Models
{
    public class YazarKitap
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public Yazar Author { get; set; }
        public Kitap Book { get; set; }
    }
}
