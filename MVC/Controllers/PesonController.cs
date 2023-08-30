using Microsoft.AspNetCore.Mvc;

namespace MVC.PesonController
{
    public class PesonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name)
        {
            ViewBag.thongBao = "Xin chào " + Name;
            return View();
        } 
    }
}