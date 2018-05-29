using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieSite.Models
{
    public class Movie
    {
        [Key]
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public DateTime FilmReleaseDate { get; set; }
        public int FilmDirectorID { get; set; }
        public string FilmSynopsis { get; set; }
    }
}