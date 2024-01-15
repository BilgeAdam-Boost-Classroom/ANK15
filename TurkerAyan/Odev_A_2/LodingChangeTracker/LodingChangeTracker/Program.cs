using LodingChangeTracker.Concrete;
using LodingChangeTracker.Context;
using Microsoft.EntityFrameworkCore;

namespace LodingChangeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UygulamaDbContext _db = new UygulamaDbContext();

            //var urun = _db.Uruns.FirstOrDefault(u => u.Id == 1);//LazyLoading
            //var urun2 = _db.Uruns.Include(u=>u.Lisans).FirstOrDefault(u => u.Id == 1);//Eager
            //_db.Entry(urun).Reference(u => u.Lisans).Load();
            //Console.WriteLine(urun.Lisans.Numara);
            //Console.WriteLine("Eager"+urun2.Lisans.Numara);

            var urun = _db.Uruns.FirstOrDefault(u => u.Id == 1);
            urun.Ad = "Tablet";
            Console.WriteLine("Yeni özellikler atadıktan sonra: "+ _db.Entry(urun).State);

        }
    }
}
