using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_5.Entity.Siniflar
{
    public class Araba :MotorluTasit
    {
        public override void Git()
        {
            Console.WriteLine("Araba Gidiyor");
        }
    }
}
