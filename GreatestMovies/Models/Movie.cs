using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatestMovies.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double BoxOfficeGross { get; set; }

        [ForeignKey("Genre")]
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

        [ForeignKey("Actor")]
        public int ActorID { get; set; }
        public virtual Actor Actor { get; set; }
    }
}