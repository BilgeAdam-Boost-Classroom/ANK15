using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Model
{
    internal abstract class Canli
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public abstract void SesCikar();
    }
}
