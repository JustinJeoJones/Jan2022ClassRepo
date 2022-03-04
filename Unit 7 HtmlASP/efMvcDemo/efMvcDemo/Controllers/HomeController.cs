using efMvcDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace efMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> result = null;

            using(SchoolContext context = new SchoolContext())
            {
                result = context.Students.ToList();
            }

            return View(result);
        }

        public IActionResult SaveStudent(Student st)
        {
            using(SchoolContext context = new SchoolContext())
            {
                context.Students.Add(st);
                context.SaveChanges();
            }
            return Redirect("/");
        }

        public IActionResult Courses()
        {
            List<Course> result = null;

            using (SchoolContext context = new SchoolContext())
            {
                result = context.Courses.ToList();
            }

            return View(result);
        }

        public IActionResult SaveCourse(Course c)
        {
            using(SchoolContext context = new SchoolContext())
            {
                context.Courses.Add(c);
                context.SaveChanges();
            }
            return RedirectToAction("Courses");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StudentView(int id)
        {
            Student result = null;

            using(SchoolContext context = new SchoolContext())
            {
                result = context.Students.First(s => s.StudentId == id);
            }

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}