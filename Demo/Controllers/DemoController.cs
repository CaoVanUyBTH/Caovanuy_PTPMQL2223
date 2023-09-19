using System.Net;
using Microsoft.AspNetCore.Mvc;
namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public ActionResult Demo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Demo(string FName)
        {
            ViewBag.demo = "Họ tên của bạn là " + FName;
            return View();
        }
    }
}