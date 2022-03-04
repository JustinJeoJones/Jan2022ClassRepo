using ASPLecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPLecture.Controllers
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
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Result()
        {
            ViewData["Message"] = "You found the result page";
            ViewData["Age"] = 24;

            ViewBag.FavDogBreed = "Husky";

            //temp data will clear after view is displayed
            TempData["CurrentInterest"] = "Risk of Rain 2";
            

            return View();
        }

        public IActionResult UserForm()
        {
            return View();
        }

        public IActionResult UserResult(string Username, string Password)
        {
            ViewData["Username"] = Username;
            ViewData["Password"] = Password;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}