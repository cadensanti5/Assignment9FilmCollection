using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadenAssignment3FilmCollection.Models
{
    public class AddMovieModel
    {
        [Key]
        [Required]
        public int movieId { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public string edited { get; set; }

        public string lent { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }
    }
}
