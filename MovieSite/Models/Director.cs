using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSite.Models
{
    public class Director
    {
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public DateTime DirectorDOB { get; set; }
        public string DirectorGender { get; set; }
    }
}