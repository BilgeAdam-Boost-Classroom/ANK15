using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15BankaUygulamasiAltYapisi.Interfaces
{
    public interface IBanka
    {
        //Musteriler
        public BindingList<IMusteri> Musteriler { get; set; }
        public INumarator numarator { get; set; }
    }
}
