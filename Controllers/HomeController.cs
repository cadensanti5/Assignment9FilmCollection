using CadenAssignment3FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return RedirectToAction("ShowMovies");
            }

            return View(m);
        }

        [HttpGet]
        public IActionResult Edit(int id = 0)
        {
            //finding the movieId then autopopulating the edit page with that movie's info
            AddMovieModel _mov = context.Movies.Find(id);
            if (_mov == null)
            {
                //return HttpNotFound();
            }
            return View(_mov);
        }

        [HttpPost]
        public IActionResult Edit(AddMovieModel _mov)
        {
            if (ModelState.IsValid)
            {
                //modifying the entry and saving the changes
                context.Entry(_mov).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("ShowMovies");
            }
            return View(_mov);
        }

        public IActionResult Delete(int id = 0)
        {
            //finding the movieId and deleting it and saving the database
            AddMovieModel _movie = context.Movies.Find(id);
            context.Movies.Remove(_movie);
            context.SaveChanges();
            return RedirectToAction("ShowMovies");
        }

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
