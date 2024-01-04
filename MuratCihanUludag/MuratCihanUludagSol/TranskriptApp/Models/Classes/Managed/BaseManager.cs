using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;
using TranskriptApp.Models.Abstract.Managed;

namespace TranskriptApp.Models.Classes.Managed
{
    public abstract class BaseManager<T> : IBaseManager<T> where T : class, IBaseEntity, new()
    {
        protected List<T> _list;
        protected T _item;

        public BaseManager(List<T> list)
        {
            _list = list;
        }

     

        public void Add(T item)
        {
            _item = item;

            _list.Add(item);
        }

        public T Get(int id)
        {
            return _list.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _list;
        }

        public virtual void Put(int id, T item)
        {
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }
    }
}
