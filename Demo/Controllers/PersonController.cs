using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person ps)
        {
            ViewBag.ps = "Thông tin là "  + ps.PersonName + "-" + ps.PersonID + "-" + ps.PersonAddress;
            return View();
        }
    }
}