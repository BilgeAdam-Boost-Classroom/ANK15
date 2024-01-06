using ANK15TRANSKRİPT.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ANK15TRANSKRİPT.Manager
{
    public interface IRepository<T> where T: class, IEntity, new()
    {
        public void Add(T item, List<T> database);
        public void Update(T oldItem, T newItem, List<T> database);
        public void Delete(T item, List<T> database);
        public T Get(Expression<Func<T, bool>> filter, List<T> database);
        public List<T> GetAll(Expression<Func<T,bool>> filter=null, List<T> database=null);


    }
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        public void Add(T item, List<T> database)
        {
            database.Add(item);
        }

        public void Delete(T item, List<T> database)
        {
            database.Remove(item);
        }

        public T Get(Expression<Func<T, bool>> filter, List<T> database)
        {
            return database.FirstOrDefault(filter.Compile());
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null, List<T> database = null)
        {
            return filter is not null ? database.Where(filter.Compile()).ToList() : null;
        }

        public void Update(T oldItem,T newItem, List<T> database)
        {
            var itemİndex = database.IndexOf(oldItem);
            if (itemİndex>=0)
            {
                database[itemİndex] = newItem;
            }
        }
    }

    public class OgrenciManager:BaseRepository<Ogrenci>
    {

    }
    public class DersOgrenciManager : BaseRepository<DersOgrenci>
    {

    }
    public class DersManager : BaseRepository<Ders>
    {

    }
    public class DonemManager : BaseRepository<Donem>
    {

    }    
}
