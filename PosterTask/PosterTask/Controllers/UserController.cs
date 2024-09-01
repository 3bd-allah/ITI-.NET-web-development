using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // Read All
        public IActionResult Index()
        {
            var users = context.Users.ToList();
            return View(users);
        }

        // Read by Id
        public IActionResult Details(int id)
        {
            var user = context.Users.SingleOrDefault(u => u.Id == id);
            if (user == null) return Content("User is not Found");
            else return View(user);
        }

        // create 
        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult AddToDB(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete 
        public IActionResult DeleteUser(int id)
        {
            var userToDelete = context.Users.Where(user => user.Id == id).SingleOrDefault();
            context.Users.Remove(userToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        // Update
        public IActionResult EditForm(int id)
        {
            User user = context.Users.SingleOrDefault(user => user.Id == id);
            return View(user); 
        }
        public IActionResult EditAction(User user)
        {
            var userToUpdate = context.Users.Where(u => u.Id == user.Id).SingleOrDefault();
            if(userToUpdate == null) return Content("Invalid User");
            userToUpdate.Name = user.Name;
            userToUpdate.Age = user.Age; 
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
