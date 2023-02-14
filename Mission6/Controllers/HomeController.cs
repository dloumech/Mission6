using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using Mission6AssignmentDarbyMecham.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private NewMovieContext _movieContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, NewMovieContext nmc)
        {
            _logger = logger;
            _movieContext = nmc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewPodcast()
        {
            return View("Podcast");
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(NewMovie nm)
        {
            _movieContext.Add(nm);
            _movieContext.SaveChanges();
            return View("Confirmation", nm);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
