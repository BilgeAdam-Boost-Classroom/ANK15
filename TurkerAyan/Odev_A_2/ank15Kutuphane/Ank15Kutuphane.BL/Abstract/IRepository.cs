using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15Kutuphane.BL.Abstract
{
    public interface IRepository<T> where T : class
    {
        public void Ekle(T type);

        public void Guncele();

        public void Sil(T type);

        public List<T> HepsiniGetir();

        public T IdyeGoreGetir(int id);


    }
}
