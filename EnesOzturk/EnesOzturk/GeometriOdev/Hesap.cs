using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdev
{
    public class Hesap
    {
        private int _aci;
        public int Aci {
            get { return _aci; }
            set { 
                if (0<=value && value<=360 )
                   _aci = value;
                else
                {
                    Console.WriteLine(  "0 ile 360 arasında değer giriniz");
                }
            }
        
        }


    }
}
