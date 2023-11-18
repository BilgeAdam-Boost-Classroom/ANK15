using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3SonSoru
{
    public class Canta
    {
        private int _hacim;
        private int _agirlik;

        public int Hacim {

            get { return _hacim; }
            set
            {
                if (value>0) 
                _hacim = value;

                else
                {
                    Console.WriteLine(  "0 dan büyük değer giriniz");
                }
            }
        
        }

        public int Agirlik {
            get 
            {
                return _agirlik;
            } set
            {

                if (value>0)
                {
                    _agirlik = value;
                }
                else
                {
                    Console.WriteLine(  "0 dan büyük değer giriniz");
                }
            }
        
        
        }




    }
    
}
