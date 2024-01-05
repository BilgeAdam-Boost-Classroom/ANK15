using BankaUygulamasi.AltYapi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi.Entities
{
    public class TitanicBank : IBanka
    {
        public BindingList<IMusteri> musteriler { get; set; }
        public INumarator Numarator { get ; set ; }
    }
}
