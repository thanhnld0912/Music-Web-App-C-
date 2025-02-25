using Microsoft.AspNetCore.Mvc;

namespace MusicWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
