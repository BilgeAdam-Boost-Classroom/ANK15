using ANK15Identity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ANK15Identity.Controllers
{
    public class StudentRoleController : Controller
    {
        private readonly UserManager<ANK15IdentityUser> _userManager;

        public StudentRoleController(UserManager<ANK15IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            //Bütün kullanıcıları listeleme yeri
            //Bütün kullanıcıları view'ına model olarak gönder
           
            return View(await _userManager.Users.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Ekle(string id)
        {
            //Yanındaki butona tıklanan kullanıcıyı id'den getir ve model olarak view'ına aktar. 
            //Neden?
            //Çünkü ....... kullanıcısına çğrenci rolünü eklemek istiyor musunuz? Diye soracağız. Onun için o kişiyi view'a model olarak göndermemiz gerekir.

            var kullanici = await _userManager.FindByIdAsync(id);
            return View(kullanici);
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(ANK15IdentityUser kullanici)
        {

            var guncellenecekKullanici = await _userManager.FindByIdAsync(kullanici.Id);
            //Form post edildiğinde gelen kullanıcıya rol ata ve listeleme ekranına dön
            await _userManager.AddToRoleAsync(guncellenecekKullanici, "Student");
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Sil(string id)
        {
            //Yanındaki butona tıklanan kullanıcıyı id'den getir ve model olarak view'ına aktar. 
            //Neden?
            //Çünkü ....... kullanıcısına çğrenci rolünü silmek istiyor musunuz? Diye soracağız. Onun için o kişiyi view'a model olarak göndermemiz gerekir.

            var kullanici = await _userManager.FindByIdAsync(id);
            return View(kullanici);
        }

        [HttpPost]
        public async Task<IActionResult> Sil(ANK15IdentityUser kullanici)
        {

            var guncellenecekKullanici = await _userManager.FindByIdAsync(kullanici.Id);
            //Form post edildiğinde gelen kullanıcıdan rol çıkar ve listeleme ekranına dön
            await _userManager.RemoveFromRoleAsync(guncellenecekKullanici, "Student");
            return RedirectToAction("Index");
        }

    }
}
