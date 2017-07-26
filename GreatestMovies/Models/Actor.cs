﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreatestMovies.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}