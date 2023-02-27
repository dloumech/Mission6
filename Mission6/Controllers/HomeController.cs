using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Controllers;
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
        private NewMovieContext _movieContext { get; set; }

        //Constructor
        public HomeController( NewMovieContext nmc)
        {
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
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(NewMovie nm)
        {
            if(ModelState.IsValid)
            {
                _movieContext.Add(nm);
                _movieContext.SaveChanges();
                return View("Confirmation", nm);
            }
            else //if INvalid
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View(nm);
            }

        }

        //link for list of movies in DB
        [HttpGet]
        public IActionResult MovieList ()
        {
            //creating list to store movie data
            var MovieApplications = _movieContext.newMovies
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(MovieApplications);
        }

        [HttpGet]
        public IActionResult Edit (int movieID)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var application = _movieContext.newMovies.Single(x => x.MovieID == movieID);
            
            return View("AddMovie", application);
        }

        [HttpPost]
        public IActionResult Edit(NewMovie newM)
        {
            _movieContext.Update(newM);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete (int movieID)
        {
            var application = _movieContext.newMovies.Single(x => x.MovieID == movieID);

            return View(application);
        }
        [HttpPost]
        public IActionResult Delete (NewMovie newM)
        {
            _movieContext.newMovies.Remove(newM);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
