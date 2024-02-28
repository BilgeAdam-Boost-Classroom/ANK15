using EsyaMvc.Context;
using EsyaMvc.Entitiys;
using Microsoft.AspNetCore.Mvc;

namespace EsyaMvc.Controllers
{
    public class EsyaController : Controller
    {
        private EsyaDbContext _db;
        public EsyaController(EsyaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Esyalar.ToList());
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Esya esya)
        {
            _db.Esyalar.Add(esya);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var silinecekEsya = _db.Esyalar.Find(id);
            return View(silinecekEsya);
        }
        [HttpPost]
        public IActionResult Sil(Esya esya)
        {
            _db.Esyalar.Remove(esya);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Guncelle(int id)
        {
            var guncellenecekEsya = _db.Esyalar.Find(id);
            return View(guncellenecekEsya);
        }
        [HttpPost]
        public IActionResult Guncelle(Esya esya)
        {
            _db.Esyalar.Update(esya);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Ara()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ara(string kelime)
        {
            return View(_db.Esyalar.Where(e => e.Name.Contains(kelime)).ToList());
        }
        public IActionResult Antikalar()
        {
            return View("Index", model: _db.Esyalar.Where(e => e.isAntika == true).ToList());
        }
        public IActionResult AntikaOlmayanlar()
        {
            //return View("Index", model: _db.Esyalar.Where(e => e.isAntika == false).ToList());
            return View(_db.Esyalar.Where(e => !e.isAntika).ToList());
        }
    }
}
