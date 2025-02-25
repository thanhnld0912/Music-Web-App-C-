using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MusicWebApp.Data;
using MusicWebApp.Models;
using System.Linq;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

        if (user != null)
        {
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserRole", user.Role);

            if (user.Role == "Admin")
                return RedirectToAction("Dashboard", "Admin");
            else
                return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Invalid email or password.";
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
