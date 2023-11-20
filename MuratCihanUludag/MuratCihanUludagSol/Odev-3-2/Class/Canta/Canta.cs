using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_2.Class.Canta
{
    internal class Canta
    {
        private int _hacim;
        private int _agirlik;    

        public int Hacim  
        { 
            get 
            {
                return _hacim;
            } 
            set 
            {
                if (!(value < 0))
                {
                    _hacim = value; 
                }
            } 
        }
        public int Agirlik  
        { 
            get 
            {
                return _agirlik;
            } 
            set 
            {
                if (!(value < 0))
                {
                    _agirlik = value;   
                }
            } 
        }
    }
}
