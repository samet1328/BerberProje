using Microsoft.AspNetCore.Mvc;

namespace KuaforDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkinda()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
