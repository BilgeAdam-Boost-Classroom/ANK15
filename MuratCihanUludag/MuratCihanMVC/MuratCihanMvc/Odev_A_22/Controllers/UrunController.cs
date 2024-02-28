using Microsoft.AspNetCore.Mvc;
using Odev_A_22.Models;

namespace Odev_A_22.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Liste()
        {
            List<Urun> urunList = new List<Urun>();

            for (int i = 1; i <= 5; i++)
            {
                urunList.Add(new Urun());
            }

            return View(urunList);
        }
    }
}
