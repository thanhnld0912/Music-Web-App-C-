using Microsoft.AspNetCore.Mvc;

namespace MusicWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
