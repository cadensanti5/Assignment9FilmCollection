using CadenAssignment3FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadenAssignment3FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieListContext context { get; set; }

        //Contstructor
        public HomeController(MovieListContext con)
        {
            context = con;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieModel m)
        {
            if (ModelState.IsValid)
            {
                //update database
                context.Movies.Add(m);
                context.SaveChanges();
            }

            return View();
        }

        //[HttpPost]
        //public IActionResult AddMovie(AddMovieModel appResponse)
        //{
        //    TempStorage.AddMovie(appResponse);
        //    return View("Confirmation", appResponse);

        //}
        public IActionResult ShowMovies()
        {
            return View(context.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
