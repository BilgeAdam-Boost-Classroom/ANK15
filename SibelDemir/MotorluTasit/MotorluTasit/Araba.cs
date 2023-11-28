using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MotorluTasit
{
    public class Araba:MotorluTasit
    {
        public override void Git()
        {
            Console.WriteLine("Araba gidiyor...");
        }
    }
}
