using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YirmiYediSubat.Models;

namespace YirmiYediSubat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index2(int id)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
                {
                new Ogrenci { Id = 1, Ad="Ali",Soyad="Kara",Numara="as1123"},
                new Ogrenci { Id = 2, Ad="Ali2",Soyad="Kara2",Numara="as2123"},
                new Ogrenci { Id = 3, Ad="Ali3",Soyad="Kara3",Numara="as3123"},
                new Ogrenci { Id = 4, Ad="Ali4",Soyad="Kara4",Numara="as4123"},
            };
            var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == id);
            return new JsonResult(ogrenci);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
