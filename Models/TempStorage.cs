using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadenAssignment3FilmCollection.Models
{
    public static class TempStorage
    {
        private static List<AddMovieModel> movies = new List<AddMovieModel>();

        public static IEnumerable<AddMovieModel> Movies => movies;

        public static void AddMovie(AddMovieModel movie)
        {
            movies.Add(movie);
        }
    }
}
