using Microsoft.AspNetCore.Mvc;

namespace MvcOnIkiSubat.Controllers
{
    public class YurtIci : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ege()
        {
            return View();
        }
        public IActionResult Akdeniz()
        {
            return View();
        }
    }
}
