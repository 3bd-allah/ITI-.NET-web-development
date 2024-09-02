using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PosterTask.Models;
using System.Data;

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
            TempData["AddNotification"] = "User Added Successfully";
            return RedirectToAction("Index");
        }

        //Delete 
        public IActionResult DeleteUser(int id)
        {
            var userToDelete = context.Users.Where(user => user.Id == id).SingleOrDefault();
            context.Users.Remove(userToDelete);
            context.SaveChanges();
            TempData["DeleteNotification"] = "User Deleted Successfully";
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
            TempData["EditNotification"] = "New Data Confirmed";
            return RedirectToAction("Index");
        }

        ///
        /// State Management

        public IActionResult FormToSetData()
        {
            return View();
        }
        public IActionResult FormToAddData(string name, string phone)
        {
            var options = new CookieOptions { Expires = DateTime.Now.AddSeconds(3f)};
            Response.Cookies.Append("name", name);
            Response.Cookies.Append("phone", phone,options);
            return RedirectToAction("GetData");
        }

        public IActionResult GetData()
        {
            string nameCookie = Request.Cookies["name"];
            string phoneCookie = Request.Cookies["phone"];
            return View(new { name= nameCookie, phone = phoneCookie});
        }
    }
}
