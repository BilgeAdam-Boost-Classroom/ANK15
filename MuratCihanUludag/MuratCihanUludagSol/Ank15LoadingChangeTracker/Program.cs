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

            //var urun = _db.Urunler
            //       .Include(u => u.Lisans)
            //       .Include(u => u.Bandrol)
            //       .ThenInclude(u => u.Onay)
            //       .FirstOrDefault(u => u.Id == 1);

            //Console.WriteLine($"{urun.Lisans.No} {urun.Bandrol.Onay.IsSuccess}");

            // 1 adet urun ekleyelim


            #region Ekleme
            //Urun urun1 = new Urun();
            //urun1.Name = "test";
            // _db.Urunler.Add(urun1); 

            //Console.WriteLine($"db.add 'den sonra: {_db.Entry(urun1).State}" );

            //_db.SaveChanges();

            //Console.WriteLine($"db.saveChange 'den sonra: {_db.Entry(urun1).State}"); 
            #endregion

            #region Guncelleme
            //var guncellenecekUrun = _db.Urunler.FirstOrDefault(u => u.Id == 2);

            //guncellenecekUrun.Name = "Masa";

            //Console.WriteLine($"Yeni Ozellikler atandiktan sonra: {_db.Entry(guncellenecekUrun).State}");

            //_db.SaveChanges();

            //Console.WriteLine($"db.saveChange 'den sonra: {_db.Entry(guncellenecekUrun).State}"); 
            #endregion

            #region Deleted
            //var silinecekUrun = _db.Urunler.FirstOrDefault(u => u.Id == 2);

            //_db.Urunler.Remove(silinecekUrun);

            //Console.WriteLine($"Remove atildiktan sonra atandiktan sonra: {_db.Entry(silinecekUrun).State}");

            //_db.SaveChanges();

            //Console.WriteLine($"db.saveChange 'den sonra: {_db.Entry(silinecekUrun).State}"); 
            #endregion
            //for (int i = 1; i <= 10; i++)
            //{
            //    Urun urun = new Urun();
            //    urun.Name = "Table" + i;
            //    _db.Urunler.Add(urun);
            //    _db.SaveChanges();
            //}



            var urunler = _db.Urunler.ToList();
            foreach (var item in _db.ChangeTracker.Entries())
            {
                Console.WriteLine($"Varlik turu: {item.Entity.GetType().Name} Durum: {item.State}");
            }

            Console.ReadLine();
        }
    }
}
