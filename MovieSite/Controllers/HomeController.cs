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
            new Movie() {FilmID = 1, FilmName = "The Big Lebowski"},
            new Movie() {FilmID = 2, FilmName = "Star Wars"},
            new Movie() {FilmID = 3, FilmName = "Stranger than Fiction"},
            new Movie() {FilmID = 4, FilmName = "Cast Away"},
            new Movie() {FilmID = 5, FilmName = "The Terminal"},
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