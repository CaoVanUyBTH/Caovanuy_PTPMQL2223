using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.emp = "Thông tin Employee là: " + FullName;
            return View();
        }
    }
}