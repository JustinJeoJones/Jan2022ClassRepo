﻿using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DeckDAL deckDAL = new DeckDAL();

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

        public IActionResult Cards()
        {
            DeckModel result = deckDAL.GetCards();
            if(result.remaining == 0)
            {
                deckDAL.ShuffleCards();
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