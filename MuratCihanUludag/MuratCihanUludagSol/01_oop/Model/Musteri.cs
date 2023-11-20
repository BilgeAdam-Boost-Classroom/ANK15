using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_oop.Model
{
    internal class Musteri
    {
        private long _tcKimlik;
        public long TcKimlik
        {
            get
            {
                return _tcKimlik;
            }
            set
            {
                if (value.ToString().Length == 11)
                    _tcKimlik = value;
                else
                    throw new ArgumentException("Hatali giris yaptiniz");
            }
        }
    }
}
