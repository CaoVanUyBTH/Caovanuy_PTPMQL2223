using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class GPTB2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string HesoA, string HesoB, string HesoC)
        {
            double delta, x1, x2, a=0, b=0, c=0;
            string Ketqua;
            if (!String.IsNullOrEmpty(HesoA)) a = Convert.ToDouble(HesoA);
            if (!String.IsNullOrEmpty(HesoB)) b = Convert.ToDouble(HesoB);
            if (!String.IsNullOrEmpty(HesoC)) c = Convert.ToDouble(HesoC);
            if (a==0) Ketqua = "Là phương trình bậc 1";
            else{
                delta = Math.Pow(b,2) - 4*a*c;
                if (delta<0) Ketqua = "Phương trình vô nghiệm";
                else if (delta==0)
                {
                    x1 = -b/(2*a);
                    Ketqua ="Phương trình có nghiệm kép ="+ x1;
                }
                else{ 
                    x1= (-b + Math.Sqrt(delta)) / (2*a);
                    x2= (-b - Math.Sqrt(delta)) / (2*a);
                    Ketqua = "Phương trình có hai nghiệm phân biệt là: x1 = "+ x1 + ", x2 = "+ x2;
                    }
                }
        ViewBag.GPTB2 = Ketqua;
        return View();
        }

    }
}