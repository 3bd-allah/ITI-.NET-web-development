using Microsoft.AspNetCore.Mvc;
using PosterTask.Models;

namespace PosterTask.Controllers
{
    public class UserController : Controller
    {
        private readonly PosterDbContext context;
        public UserController(PosterDbContext _context)
        {
            this.context = _context;
        }
        public IActionResult Index()
        {
            var users = context.Users.ToList();
            return View(users);
        }

        public IActionResult Details(int id)
        {
            var user = context.Users.SingleOrDefault(u => u.Id == id);
            if (user == null) return Content("User is not Found");
            else return View(user);
        }
    }
}
