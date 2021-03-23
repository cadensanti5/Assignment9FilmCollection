using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadenAssignment3FilmCollection.Models
{
    public class SavedMovies
    {
        public List<MovieLine> Lines { get; set; } = new List<MovieLine>();

        //public virtual void RemoveMovie(AddMovieModel movies)
        //{
        //    MovieLine line = Lines
        //        .Where(p => p.Movies.movieId == movies.movieId)
        //        .FirstOrDefault();
        //    Lines.RemoveAll(x => x.Movies.movieId == movies.movieId);
        //}
        public class MovieLine
        {
            public int MovieLineId { get; set; }
            public AddMovieModel Movies { get; set; }
        }
    //    public static IEnumerable<AddMovieModel> Movies => movies;

    //    public static void AddMovie(AddMovieModel movie)
    //    {
    //        movies.Add(movie);
    //    }
    }
}
