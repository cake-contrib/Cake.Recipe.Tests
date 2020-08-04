using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? n1, int? n2)
        {
            if (n1.HasValue && n2.HasValue)
            {
                int sum = MathClass.Add(n1.Value, n2.Value);

                return View(sum);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}