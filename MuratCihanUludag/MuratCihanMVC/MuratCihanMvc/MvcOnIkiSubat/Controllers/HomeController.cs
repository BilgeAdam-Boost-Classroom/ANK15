using Microsoft.AspNetCore.Mvc;
using MvcOnIkiSubat.Models;
using System.Diagnostics;

namespace MvcOnIkiSubat.Controllers
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
            ViewBag.test1 = 1;
            ViewData["test2"] = 2;
            TempData["test3"] = 3;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.test4 = 4;
            ViewData["test5"] = 5;
            TempData["test6"] = 6;
            return RedirectToAction("Index2");
            //return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.sayi = 34;
            ViewData["sayi"] = 44;
            TempData["sayi"] = 54;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
