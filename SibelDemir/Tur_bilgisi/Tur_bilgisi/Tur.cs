using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_bilgisi
{
    public abstract class Tur
    {
        public string Familya { get; set; }
        public string Aile { get; set; }
        public string CanliTuru { get; set; }
        public virtual void TurGoster()
        {
            Console.WriteLine("tür");
        }
        public void AileGoster()
        {
            Console.WriteLine("aile goster");
        }
        public abstract void FamilyaGoster();
    }
}
