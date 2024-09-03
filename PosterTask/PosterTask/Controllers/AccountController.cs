using Microsoft.AspNetCore.Mvc;
using PosterTask.Models;
using PosterTask.ViewModels;

namespace PosterTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly PosterDbContext context; 
        public AccountController(PosterDbContext _context)
        {
            this.context = _context;
        }
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
            User? user = context.Users.SingleOrDefault
                    (u => u.Email == login.Email && u.Password == login.Password);
            if(user == null)
            {
                ViewBag.Error = "Invalid Email or Password";
                return View("LoginForm");
            }
            HttpContext.Session.SetString("UserName", user.Name);
            HttpContext.Session.SetInt32("UserId", user.Id);
            return RedirectToAction("Details", "User", new {Id= user.Id });
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
