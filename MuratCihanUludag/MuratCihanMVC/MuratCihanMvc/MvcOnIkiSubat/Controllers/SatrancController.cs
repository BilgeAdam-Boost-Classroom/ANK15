using Microsoft.AspNetCore.Mvc;

namespace MvcOnIkiSubat.Controllers
{
    public class SatrancController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewData["Count"] = id;
            return View();
        }
    }
}
