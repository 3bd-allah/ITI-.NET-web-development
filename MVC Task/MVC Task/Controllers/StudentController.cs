using Microsoft.AspNetCore.Mvc;

namespace MVC_Task.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
