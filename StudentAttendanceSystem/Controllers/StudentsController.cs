using Microsoft.AspNetCore.Mvc;

namespace StudentAttendanceSystem.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
