using Microsoft.AspNetCore.Mvc;

namespace MvcOnIkiSubat.Controllers
{
    public class GoruntuController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.SiteMsg = 45;
            return View();
        }
        public IActionResult Index2()
        {
            ViewData["SiteMsg2"] = 754;
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.SiteMsgIndex3 = 9;
            ViewData["SiteMsg3"] = 99;
            return View();
        }
        public IActionResult Index4()
        {
            ViewData["SiteMsg4"] = 800;
            return View();
        }
        public IActionResult Index5()
        {
            ViewData["SiteMsg5"] = 801;
            return View();
        }
        public IActionResult Index6()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                numbers.Add(i);
            }
            ViewData["SiteMsg6"] = numbers;
            return View();
        }
        public IActionResult Index7()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                numbers.Add(i);
            }
            ViewData["SiteMsg7"] = numbers;
            return View();
        }
        public IActionResult Rastgele()
        {
            var randomNumber = new Random();
            ViewData["SiteRandom1"] = randomNumber.Next(1, 101);
            return View();
        }
        public IActionResult Rastgele2()
        {
            var randomNumber = new Random();
            ViewData["SiteRandom2"] = randomNumber.Next(1, 101);
            return View();
        }
    }
}
