using MovieSite.Models;
using MovieSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSite.Controllers
{
    public class HomeController : Controller
    {
        List<Customer> Customers = new List<Customer>
        {
            new Customer { Name = "Darth Vader", Id = 51},
            new Customer { Name = "Yoda", Id = 161},
            new Customer { Name = "Chebacca", Id = 6},
        };

        List<Movie> Movies = new List<Movie>()
        {
            new Movie() {ID = 1, Name = "The Big Lebowski"},
            new Movie() {ID = 2, Name = "Star Wars"},
            new Movie() {ID = 3, Name = "Stranger than Fiction"},
            new Movie() {ID = 4, Name = "Cast Away"},
            new Movie() {ID = 5, Name = "The Terminal"},
        };

        public ActionResult Index()
        {
            var randomMovieModel = new RandomMovieViewModel
            {
                Customers = Customers,
                Movies = Movies
            };
            return View(randomMovieModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}