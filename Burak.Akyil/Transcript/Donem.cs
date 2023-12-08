using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcript
{
    public class Donem
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public override string ToString()
        {
            return No.ToString() + ".dönem" + " " + Ad;
        }

    }
}
