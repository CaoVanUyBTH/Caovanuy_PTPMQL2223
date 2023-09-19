using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class TinhluongController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string LuongCB, string Heso, string Phucap)
        {
            double CB =0, HS =0, PC =0, LuongNV = 0;
        string ketqua;
        if(!String.IsNullOrEmpty(LuongCB)) CB = Convert.ToDouble(LuongCB);
        if(!String.IsNullOrEmpty(Heso)) HS = Convert.ToDouble(Heso);
        if(!String.IsNullOrEmpty(Phucap)) PC = Convert.ToDouble(Phucap);
        LuongNV = CB*HS+PC;
        ketqua = "Lương của bạn là: " + LuongNV + "VNĐ";
        ViewBag.Tinhluong = ketqua;
        return View();
        }
    }
}