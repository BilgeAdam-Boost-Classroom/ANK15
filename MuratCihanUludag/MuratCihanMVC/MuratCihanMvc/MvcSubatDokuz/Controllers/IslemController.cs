using Microsoft.AspNetCore.Mvc;

namespace MvcSubatDokuz.Controllers
{
    public class IslemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View("Index");
            //Hocam disaridayim ama gosterebilriim
            
        }
        public IActionResult Index4()
        {
            return RedirectToAction("index");
        }
        public IActionResult Index5()
        {
            return RedirectToAction("index", "Home");
        }
        public IActionResult Index6()
        {
            return View();
        }
        public IActionResult Index7(int id)
        {
            return View();
        }
        public IActionResult Index7(string id)
        {
            return View();
        }
        public IActionResult Index8(int id,int x)
        {
            int id2 = id;   
            return View();
        }
        public IActionResult Index9(int x, int id)
        {
            return View();
        }
    }
}
