using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaUygulama.AltYapi.Interfaces;

namespace BankaUygulama.AltYapi.Entities
{
    public class TitanicBank : IBanka
    {
        public BindingList<IMusteri> Musteriler { get; set; }
        public INumarator Numarator { get; set; }
    }
}
