using Microsoft.AspNetCore.Mvc;

namespace CarRenta.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
