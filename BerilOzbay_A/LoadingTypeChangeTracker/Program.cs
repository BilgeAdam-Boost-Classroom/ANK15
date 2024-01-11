using LoadingTypeChangeTracker.Concrete;
using LoadingTypeChangeTracker.Context;
using Microsoft.EntityFrameworkCore;

namespace LoadingTypeChangeTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            UygulamaDbContext _db = new UygulamaDbContext();
            //Eager Loading ->
            //var urun = _db.Urunler.Include(u => u.Lisans).FirstOrDefault(u => u.Id == 1);

            //var urun = _db.Urunler.FirstOrDefault(u => u.Id == 1);
            //_db.Entry(urun).Reference(u => u.Lisans).Load();
            //Console.WriteLine(urun.Lisans.Numara);

            Lisans lisans = new Lisans();
            lisans.Numara = "1236";
            _db.Add(lisans);
            _db.SaveChanges();

            Urun urun = new Urun();
            urun.Ad = "Tablet";
            urun.LisansId = 3;
            _db.Add(urun);
            Console.WriteLine("Db added:"+ _db.Entry(urun).State); 
            _db.SaveChanges();
            Console.WriteLine("Db savechanges:" + _db.Entry(urun).State);
        }
    }
}