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
        [Required]
        public string FilmName { get; set; }
        public DateTime FilmReleaseDate { get; set; }
        public int FilmDirectorID { get; set; }
        public string FilmSynopsis { get; set; }
        public Director Director { get; set; }
        public int LangID { get; set; } 
    }
}