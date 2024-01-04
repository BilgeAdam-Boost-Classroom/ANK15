using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptApp.Models.Abstract.Managed
{
    public interface IBaseManager<T> where T : class, IBaseEntity, new()
    {
        public T Get(int id);
        public List<T> GetAll();
        public void Add(T item);
        public void Put(int id, T item);
        public void Remove(T item);
    }
}
