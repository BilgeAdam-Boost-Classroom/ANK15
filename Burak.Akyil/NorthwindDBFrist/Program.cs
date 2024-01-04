// See https://aka.ms/new-console-template for more information
using NorthwindDBFrist.Models;

Console.WriteLine("Hello, World!");

NORTHWNDContext _db = new NORTHWNDContext();
//string ad, soyad;
//Console.WriteLine("Adınızı Giriniz.");
//ad = Console.ReadLine();
//Console.WriteLine("Soyadınızı Giriniz.");
//soyad = Console.ReadLine();
//Employee yeniCalisan = new Employee();
//yeniCalisan.FirstName = ad;
//yeniCalisan.LastName = soyad;
////Db'ye ekleme bolumu
//_db.Employees.Add(yeniCalisan);
////Kaydetme metodu
//_db.SaveChanges();
//Console.WriteLine("Başarıyla eklenmiştir.");

//Güncelleme Bölümü -- Bunun için LINQ kullanılır.
//int id;
//Console.WriteLine("Güncellenecek kişinin ID'sini giriniz:");
//id = Convert.ToInt32(Console.ReadLine());
//var guncellenecekCalisan = _db.Employees.FirstOrDefault(e => e.EmployeeId == id); //LINQ
//Console.WriteLine("Güncellenecek kişinin Adını giriniz:");
//guncellenecekCalisan.FirstName = Console.ReadLine();
//Console.WriteLine("Güncellenecek kişinin Soyadını giriniz:");
//guncellenecekCalisan.LastName = Console.ReadLine();
//_db.SaveChanges();
//Console.WriteLine("Başarıyla güncellenmiştir.");

//Silme Bolumu
//int id;
//Console.WriteLine("Silinecek çalışanın ID'sini giriniz:");
//id = Convert.ToInt32(Console.ReadLine());
//var silinecekCalisan = _db.Employees.FirstOrDefault(e => e.EmployeeId == id); //LINQ
//if (silinecekCalisan != null)
//{
//    _db.Employees.Remove(silinecekCalisan);
//    _db.SaveChanges();
//    Console.WriteLine("Başarıyla silinmiştir.");
//}
//else
//    Console.WriteLine("Çalışan bulunamamıştır.");

//Gorev 1
foreach (var item in _db.Employees)
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName);
}

Console.WriteLine("-------------------------------");

//Gorev 2
foreach (var item in _db.Employees.Where(a=>a.FirstName.StartsWith("A")))
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName);
}

Console.WriteLine("-------------------------------");

//Gorev 3
foreach (var item in _db.Employees.Where(a=>a.FirstName.Contains("a")))
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName);
}

Console.WriteLine("-------------------------------");

//Gorev 4
var max = _db.Products.Max(un => un.UnitPrice);
foreach (var item in _db.Products.Where(u=>u.UnitPrice == max))
{
    Console.WriteLine("Ürün Adı: " + item.ProductName);
}

Console.WriteLine("-------------------------------");

//Gorev 5
var min = _db.Products.Min(un=>un.UnitPrice);
foreach (var item in _db.Products.Where(u=>u.UnitPrice == min))
{
    Console.WriteLine("Ürün Adı: " + item.ProductName);
}

Console.WriteLine("-------------------------------");

//Gorev 6
foreach (var item in _db.Products.OrderBy(u=>u.UnitsInStock).ThenBy(u=>u.ProductName))
{
    Console.WriteLine("Ürün Adı: " + item.ProductName + ", " + "Stoktaki Miktarı: " + item.UnitsInStock);
}
Console.WriteLine("-------------------------------");

//Gorev 7
var lastPerson = _db.Employees.ToList().LastOrDefault();
Console.WriteLine(lastPerson.FirstName + " " + lastPerson.LastName);

Console.WriteLine("-------------------------------");

//Gorev 8
var firstPerson = _db.Employees.ToList().FirstOrDefault();
Console.WriteLine(firstPerson.LastName + " " + firstPerson.LastName);

Console.WriteLine("-------------------------------");

//Gorev 9
var person = _db.Employees.OrderBy(e => e.BirthDate).FirstOrDefault();
Console.WriteLine("Adı: " + person.FirstName);
Console.WriteLine("-------------------------------");

//Gorev 10
var person1 = _db.Employees.OrderByDescending(e => e.BirthDate).LastOrDefault();
Console.WriteLine("Adı: " + person1.FirstName + " " + "Doğum Tarihi: " + person1.BirthDate);

Console.WriteLine("-------------------------------");

//Gorev 11
foreach (var item in _db.Employees.Where(e=>e.Address.Contains("House") || e.TitleOfCourtesy == "Dr."))
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName + ", " + "Adresi: " + item.Address);
}

Console.WriteLine("-------------------------------");

//Gorev 12
foreach (var item in _db.Employees.Where(e=>!e.Address.Contains("House") || e.TitleOfCourtesy == "Mr.").OrderByDescending(e=>e.FirstName))
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName + ", " + "Unvanı: " + item.TitleOfCourtesy + ", " + "Adresi: " + item.Address);
}

Console.WriteLine("-------------------------------");

//Gorev 13
foreach (var item in _db.Employees.Where(e=>e.FirstName == "Andrew"))
{
    Console.WriteLine("Adı: " + item.FirstName + ", " + "Soyadı: " + item.LastName + ", " + "Adresi: " + item.Address);
}

Console.WriteLine("-------------------------------");

//Gorev 14 
var employee = _db.Employees.Where(e => e.FirstName.StartsWith("A")).FirstOrDefault();
Console.WriteLine("Adı: " + employee.FirstName + ", " + "Soyadı: " + employee.LastName + ", " + "Doğum Tarihi: " + employee.BirthDate);

Console.WriteLine("-------------------------------");

//Gorev 15
var avg = _db.Products.Average(p => p.UnitPrice);
foreach (var item in _db.Products.Where(p=>p.UnitPrice > avg))
{
    Console.WriteLine("Adı: " + item.ProductName + ", " + "Fiyatı: " + item.UnitPrice);
}