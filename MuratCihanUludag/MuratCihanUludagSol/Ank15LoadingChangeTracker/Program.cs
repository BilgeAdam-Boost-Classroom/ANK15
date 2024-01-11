using Ank15LoadingChangeTracker.Concrete;
using Ank15LoadingChangeTracker.Context;
using Microsoft.EntityFrameworkCore;

namespace Ank15LoadingChangeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UygulamaDbContext _db = new UygulamaDbContext();


            // EagleLoadingtir tek seferde her seyi getirirsin.

            //var urun = _db.Urunler
            //           .Include(u => u.Lisans)
            //           .FirstOrDefault(u => u.Id == 1);asd


            // LazyLoading turu claslarda da navigasyonlari virtual yapilmistir.

            //var urun = _db.Urunler.FirstOrDefault(u => u.Id == 1);

            //Entery Kullanimi LazyLoading kapaliyken lazyLoading yapar 

            //db.Entry(urun).Reference(u => u.Lisans).Load();

            _db.Bandroller.Add(new Bandrol { Name="test"});

            //Console.WriteLine(urun.Lisans.No);
            Console.ReadLine();
        }
    }
}
