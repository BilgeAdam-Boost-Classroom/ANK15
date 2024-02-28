using Microsoft.AspNetCore.Mvc;
using System.Data;
using YirmiYediSubat.Context;
using YirmiYediSubat.Entities;

namespace YirmiYediSubat.Controllers
{
    public class MalzemeController : Controller
    {
        private YirmiYediSubatDbContext _db;
        public MalzemeController(YirmiYediSubatDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetTableList()
        {
            return PartialView(_db.Malzemeler.ToList());
        }
        public IActionResult Listeleme()
        {
            return new JsonResult(_db.Malzemeler.ToList());
        }
        public IActionResult Add(Malzeme malzeme)
        {
            _db.Malzemeler.Add(malzeme);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleteMalzeme = _db.Malzemeler.Find(id);
            _db.Malzemeler.Remove(deleteMalzeme);
            _db.SaveChanges(true);
            return Ok();
        }
    }
}
