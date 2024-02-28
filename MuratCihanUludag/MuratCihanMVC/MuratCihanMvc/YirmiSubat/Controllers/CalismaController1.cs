using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using YirmiSubat.Models;

namespace YirmiSubat.Controllers
{
    public class CalismaController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Calisma1()
        //{
        //    return View();
        //}
        //public PartialViewResult Calisma2()
        //{
        //    return PartialView();
        //}
        //public JsonResult Calisma3()
        //{
        //    Araba araba = new Araba()
        //    {
        //        Model = "2022",
        //        Renk = "Mavi"
        //    };
        //    return new JsonResult(araba);
        //}
        //public EmptyResult Calisma4()
        //{
        //    return new EmptyResult();
        //}

        //public RedirectToActionResult Calisma5()
        //{
        //    return RedirectToAction("Index");
        //}
        //public StatusCodeResult Calisma6()
        //{
        //    return new StatusCodeResult(404);
        //}
        //public ContentResult Calisma7()
        //{
        //    return Content($"Merhaba, bugun {DateTime.Now.ToString("dd:mm:yyyy")}");
        //}
        //public NotFoundResult Calisma8()
        //{
        //    return new NotFoundResult();
        //}
        //public NotFoundResult Calisma9()
        //{
        //    return View();
        //}
        //public PartialViewResult Calisma10()
        //{
        //    return View();
        //}
        //public IActionResult Calisma11()
        //{
        //    Araba araba = new Araba()
        //    {
        //        Model = "2022",
        //        Renk = "Mavi"
        //    };
        //    return new JsonResult(araba);
        //}
        //public StatusCodeResult Calisma13()
        //{
        //    return RedirectToAction("Index");
        //}
        //public JsonResult Calisma15()
        //{
        //    return Content($"Merhaba, bugun {DateTime.Now.ToString("dd:mm:yyyy")}");
        //}
        //public IActionResult Calsima17()
        //{
        //    return new NotFoundResult();
        //}
    }
}
