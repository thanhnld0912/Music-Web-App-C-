using Microsoft.AspNetCore.Mvc;
using MusicWebApp.Data;
using MusicWebApp.Models;

namespace MusicWebApp.Controllers
{
    public class SongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Upload() => View();

        [HttpPost]
        public IActionResult Upload(Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Songs.Add(song);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(song);
        }
    }
}
