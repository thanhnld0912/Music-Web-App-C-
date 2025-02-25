using Microsoft.AspNetCore.Mvc;

namespace MusicWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
