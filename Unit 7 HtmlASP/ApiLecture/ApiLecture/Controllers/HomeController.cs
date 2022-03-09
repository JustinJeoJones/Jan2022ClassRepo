using ApiLecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiLecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StarwarsDAL starwarsDAL = new StarwarsDAL();
        private WeatherDAL weatherDAL = new WeatherDAL();

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

        public IActionResult Starwars(int id)
        {
            StarwarsCharacter result = starwarsDAL.GetStarwarsCharacter(id);
            return View(result);
        }

        public IActionResult StarwarsName(string name)
        {
            StarwarsCharacter result = starwarsDAL.SearchStarwarsCharacter(name);
            return View(result);
        }

        public IActionResult Weather(string city)
        {
            WeatherModel result = weatherDAL.GetWeather(city);
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}