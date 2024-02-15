using Microsoft.AspNetCore.Mvc;
using MvcOnIkiSubat.Models;
using System.Runtime.CompilerServices;

namespace MvcOnIkiSubat.Controllers
{
    public class ModelUygulamaController : Controller
    {
        public IActionResult Index()
        {
            int sayi = 12;
            return View(sayi);
        }
        public IActionResult Index2()
        {
            List<string> dizi = new List<string>();
            dizi.Add("Masa");
            dizi.Add("Sandalye");
            dizi.Add("Dolap");
            dizi.Add("Tablo");

            return View(dizi);
        }
        public IActionResult Index3()
        {
            string mesaj = "test mesaj";

            return View(mesaj);
        }
        public IActionResult Index4()
        {
            List<Calisan> calisanlar = new List<Calisan>();
            calisanlar.AddRange(new List<Calisan>
            {
                new Calisan { Name = "Ali", Surname = "Kara", Age = 22 },
                new Calisan { Name = "Mehmet", Surname = "Kara", Age = 22 },
                new Calisan { Name = "Necmi", Surname = "Kara", Age = 22 }
            });

            return View(calisanlar);
        }
        public IActionResult Index5()
        {
            Calisan calisan = new Calisan();
            calisan.Name = "Ali";
            calisan.Surname = "Kara";
            calisan.Age = 22;

            return View(calisan);
        }
        [HttpGet]
        public IActionResult Index6()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index6(Calisan calisan)
        {
            return View(calisan);
        }
        public IActionResult Index7(int sayi)
        {
            ///ModelUygulama/Index7?sayi=7
            return View();
        }
        public IActionResult Index8(int id)
        {
            return View();
        }
        public IActionResult Index9()
        {
            return View();
        }
        public IActionResult Index9(int id)
        {
            return View(id);
        }
    }
}
