using Ank15SuperMarket.Context;
using Ank15SuperMarket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ank15SuperMarket.Controllers
{
    public class UrunController : Controller
    {
        private readonly MarketDbContext _context;
        public UrunController(MarketDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Butun urunlerin listelendigi yer 
            // gorunumunde butun urunleri gorebilmek icin model olarak butun runlerin listesini gondermemiz gereklidir.
            return View(_context.Urunler.ToList());
        }
        public IActionResult Ekle()
        {
            //Ekleme formunu acmak icin
            return View();
        }
        [HttpPost]
        public IActionResult Ekle([FromBody] Urun urun)
        {
            //Ekleme formunu acmak icin
            _context.Urunler.Add(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Guncelle(int id)
        {
            var guncellenecekUrun = _context.Urunler.Find(id);
            return View(guncellenecekUrun);
        }
        [HttpPost]
        public IActionResult Guncelle([FromForm] Urun urun)
        {
            _context.Urunler.Update(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Sil(int id)
        {
            var silinecekUrun = _context.Urunler.Find(id);
            return View(silinecekUrun);
        }
        [HttpPost]
        public IActionResult Sil(Urun urun)
        {
            _context.Urunler.Remove(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
