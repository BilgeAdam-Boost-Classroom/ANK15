using Microsoft.EntityFrameworkCore;
using NorthWindDbFrist.Models;

namespace NorthWindDbFrist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 28_12_2012
            ////  Veri Tabanina Nasil ulasacagiz?
            ////  Cevap: Context sinifi ile

            //NorthwindContext _db = new NorthwindContext();

            ////  Ornek1: Yeni bir employee ekleyelim
            //string ad, soyAd;
            //int id;

            //Console.WriteLine("Adinizi giriniz");
            //ad = Console.ReadLine();

            //Console.WriteLine("Adinizi giriniz");
            //soyAd = Console.ReadLine();

            ////  Yeni bir kisi olusturalim.
            //Employee newEmployee = new Employee();

            //newEmployee.FirstName = ad;
            //newEmployee.LastName = soyAd;

            ////Db' ye ekleme bolumu
            //_db.Employees.Add(newEmployee);

            //// Kayit etme islemi
            //_db.SaveChanges();
            //Console.WriteLine("Basariyla Eklenmistir.");

            //  Guncelleme
            //  Once Guncellenecek olan varligimizi veritabanindan getirmemiz gereklidir.

            //  Bunun icin LINQ kullanacagiz
            //  Guncellenecek olan varligin ID'sini kullanarak once bir bulalim.
            //   Bulmanin birden fazla yolu var. Simdilik 1 tanasine bakalim.
            //Console.WriteLine("Guncellenecek calisanin ID'sini giriniz:");
            //id = Convert.ToInt32(Console.ReadLine());

            ////Id'si, klavyeden girelen id'ye esit olan calisani bul.
            //var guncellenecekCalisan = _db.Employees.FirstOrDefault(e => e.EmployeeId == id);

            //Console.WriteLine("Adinizi giriniz");
            //guncellenecekCalisan.FirstName = Console.ReadLine();

            //Console.WriteLine("Soyadinizi giriniz");
            //guncellenecekCalisan.LastName = Console.ReadLine();

            ////Degisiklikleri Kaydet
            //_db.SaveChanges();
            //Console.WriteLine("Basariyla Guncellenmisir");

            //Console.WriteLine("Silenecek olanin ID'sini giriniz");
            //id= Convert.ToInt32(Console.ReadLine());

            //var SilinecekCalisan = _db.Employees.FirstOrDefault(e => e.EmployeeId == id);

            //_db.Employees.Remove(SilinecekCalisan);

            //_db.SaveChanges();
            //Console.WriteLine("Basariyla silindi"); 
            #endregion

            #region 02_01_2024
            NorthwindContext _context = new NorthwindContext();
            // Tum kategorileri donme
            //List<Category> allCategory = _context.Categories.ToList();

            //foreach (var item in allCategory)
            //    Console.WriteLine($"{item.CategoryName}: {item.Description}");
            //// C ile Baslayanlar
            ////foreach (var item in _context.Categories.Where(c => c.CategoryName.StartsWith('C')).ToList())
            ////    Console.WriteLine($"{item.CategoryName}: {item.Description}");

            //// 5 ten buyuk olanlari getirdik
            //Console.WriteLine(new string('-', 50));
            //foreach (var item in _context.Categories.Where(c => c.CategoryId >= 5))
            //{
            //    Console.WriteLine($"{item.CategoryId}. {item.CategoryName}: {item.Description}");
            //}
            //// Artar olarak siralama
            //Console.WriteLine(new string('-',50));
            //foreach (var item in _context.Categories.
            //    Where(c => c.CategoryId >= 5).
            //    OrderBy( o => o.CategoryName))
            //{
            //    Console.WriteLine($"{item.CategoryId}. {item.CategoryName}: {item.Description}");
            //}

            //// Azalan olarak siralama
            //Console.WriteLine(new string('-', 50));
            //foreach (var item in _context.Categories.
            //    Where(c => c.CategoryId >= 5).
            //    OrderByDescending(o => o.CategoryName))
            //{
            //    Console.WriteLine($"{item.CategoryId}. {item.CategoryName}: {item.Description}");
            //}


            //// order detailda ki productId si 1 den kucuk olan eya discount i sifirdan farkli olanlarin product id lerini geitr
            //Console.WriteLine(new string('-', 50));
            //foreach (var item in _context.OrderDetails.Where(od => od.ProductId < 11 || od.Discount!=0))
            //{
            //    Console.WriteLine($"{item.ProductId} --- {item.Discount}");
            //}

            //// Yukaridakini once productId ye gore sonra da discount a gore siralayim
            //Console.WriteLine(new string('-', 50));
            //foreach (var item in _context.OrderDetails.Where(od => od.ProductId < 11 || od.Discount != 0).OrderBy(o => o.ProductId).ThenBy(o => o.Discount))
            //{
            //    Console.WriteLine($"{item.ProductId} --- {item.Discount}");
            //}

            ////order detail unitpricelerin ortalamsini getir

            //Console.WriteLine(_context.OrderDetails.Average( a=> a.UnitPrice));
            //// min getir
            //Console.WriteLine(_context.OrderDetails.Min(a => a.UnitPrice));
            //// max i getir
            //Console.WriteLine(_context.OrderDetails.Max(a => a.UnitPrice));
            //// adetini getir
            //Console.WriteLine(_context.OrderDetails.Count());
            //// Unitprice 50 den buyuk adetleri geitr
            //Console.WriteLine(_context.OrderDetails.Count(c => c.UnitPrice > 50));
            ////avg den buyuk olanlari getir
            //Console.WriteLine(_context.OrderDetails.Count(c => c.UnitPrice >_context.OrderDetails.Average(c=> c.UnitPrice)));

            // Gorevler
            //1.
            foreach (var item in _context.Employees.ToList())
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.WriteLine(new string('-', 50));
            //2.
            foreach (var item in _context.Employees.Where(e => EF.Functions.Like(e.FirstName, "A%")).ToList())
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            
            //3
            Console.WriteLine(new string('-', 50));

            foreach (var item in _context.Employees.Where(e => EF.Functions.Like(e.FirstName, "%a%")).ToList())
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");

            }
            //4
            Console.WriteLine(new string('-', 50));
            foreach (var item in _context.Products.Where(p => p.UnitPrice == _context.Products.Max(m => m.UnitPrice)).ToList())
            {
                Console.WriteLine(item.ProductName);
            }
            //5
            Console.WriteLine(new string('-', 50));

            foreach (var item in _context.Products.Where(p => p.UnitPrice == _context.Products.Min(m => m.UnitPrice)).ToList())
            {
                Console.WriteLine(item.ProductName);
            }
            //6
            Console.WriteLine(new string('-', 50));

            foreach (var item in _context.Products.OrderBy(o => o.UnitsInStock).ThenByDescending(t => t.ProductName))
            {
                Console.WriteLine(item.ProductName + item.UnitsInStock);
            }
            //7
            Console.WriteLine(new string('-', 50));

            var emp = _context.Employees.ToList().LastOrDefault();
            Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //8
            Console.WriteLine(new string('-', 50));

            var emp2 = _context.Employees.ToList().FirstOrDefault();
            Console.WriteLine(emp2.FirstName + " " + emp2.LastName);
            //9
            Console.WriteLine(new string('-', 50));

            var emp3 = _context.Employees.OrderBy(o => o.BirthDate).FirstOrDefault();
            Console.WriteLine(emp3.FirstName);
            //10
            Console.WriteLine(new string('-', 50));
            var emp4 = _context.Employees.OrderByDescending(o => o.BirthDate).FirstOrDefault();
            Console.WriteLine(emp4.FirstName);
            //11
            Console.WriteLine(new string('-', 50));
            foreach (var item in _context.Employees.Where(e => e.Address.Contains("House") || e.TitleOfCourtesy.Contains("Dr.")).ToList())
            {

                Console.WriteLine($"{item.TitleOfCourtesy} {item.FirstName} {item.LastName} Adress: {item.Address}");
            }
            //12
            Console.WriteLine(new string('-', 50));
            foreach (var item in _context.Employees.Where(e => e.Address.Contains("House") || e.TitleOfCourtesy.Contains("Dr.")).OrderByDescending(e => e.FirstName).ToList())
            {
                Console.WriteLine($"{item.TitleOfCourtesy} {item.FirstName} {item.LastName} Adress: {item.Address}");
            }
            //13
            Console.WriteLine(new string('-', 50));

            foreach (var item in _context.Employees.Where(e => e.FirstName.Contains("Andrew")))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Address}");
            }
            //14
            Console.WriteLine(new string('-', 50));

            var enp5 = _context.Employees.Where(e => EF.Functions.Like(e.FirstName, "A%")).FirstOrDefault();
            Console.WriteLine($"{enp5.FirstName} {enp5.LastName} {enp5.BirthDate}");

            //15
            Console.WriteLine(new string('-', 50));
            foreach (var item in _context.Products.Where(p=> p.UnitPrice > _context.Products.Average(p => p.UnitPrice)))
            {
                Console.WriteLine($"{item.ProductId}.{item.ProductName}: {item.UnitPrice}");
            }

            #endregion

        }
    }
}