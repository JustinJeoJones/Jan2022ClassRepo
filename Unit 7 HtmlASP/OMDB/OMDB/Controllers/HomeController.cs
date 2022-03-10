using Microsoft.AspNetCore.Mvc;
using OMDB.Models;
using System.Diagnostics;

namespace OMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDAL movieDAL = new MovieDAL();

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

        public IActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            MovieModel result = movieDAL.GetMovie(title);
            return View(result);
        }

        public IActionResult MovieNight()
        {
            return View();
        }


        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            MovieModel result = movieDAL.GetMovie(title1);
            MovieModel result2 = movieDAL.GetMovie(title2);
            MovieModel result3 = movieDAL.GetMovie(title3);
            List<MovieModel> movies = new List<MovieModel>()
            {
                result,
                result2,
                result3,
            };

            return View(movies);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}