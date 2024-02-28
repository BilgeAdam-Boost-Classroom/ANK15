using Microsoft.AspNetCore.Mvc;
using YirmiSubat.Models;

namespace YirmiSubat.Controllers
{
    public class UrunController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromBody] Urun urun)
        {
            return View();
        }
    }
}
