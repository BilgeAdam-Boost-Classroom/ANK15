using Ank15Kutuphane.BL.Abstract;
using AnkKutuphane.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15Kutuphane.BL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly KutuphaneDbContext _db;
        private DbSet<T> varliklar;

        public Repository(KutuphaneDbContext db)
        {
            _db = db;
            varliklar = _db.Set<T>();
        }

        public void Dispose(T type);
        {

        }


        public void Ekle(T type)
        {
            varliklar.Add(type);
            _db.SaveChanges();
        }

        public void Guncele()
        {
            _db.SaveChanges();
        }

        public List<T> HepsiniGetir()
        {
           return varliklar.ToList();   
        }

        public T IdyeGoreGetir(int id)
        {
            return varliklar.Find(id);
        }

        public void Sil(T varlik)
        {
            varliklar.Remove(varlik);
            _db.SaveChanges();  

        }
    }
}
