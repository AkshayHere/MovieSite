using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieSite.Models;
using MovieSite.Repository;
using MovieSite.ViewModels;

namespace MovieSite.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        List<Customer> _customers = new List<Customer>
        {
            new Customer { Name = "Darth Vader", Id = 51},
            new Customer { Name = "Yoda", Id = 161},
            new Customer { Name = "Chebacca", Id = 6},
        };

        List<Movie> _movies = new List<Movie>()
        {
            new Movie() {FilmID = 1, FilmName = "The Big Lebowski"},
            new Movie() {FilmID = 2, FilmName = "Star Wars"},
            new Movie() {FilmID = 3, FilmName = "Stranger than Fiction"},
            new Movie() {FilmID = 4, FilmName = "Cast Away"},
            new Movie() {FilmID = 5, FilmName = "The Terminal"},
        };

        // GET: Movies
        public ActionResult Random()
        {
            var randomMovieModel = new RandomMovieViewModel
            {
                Customers = _customers,
                Movies = _movies
            };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            return View(randomMovieModel);
            //return Content(movie.Name); // Get the Text on the Page
            //return ViewResult(); // Redirect to view
            //return HttpNotFound(); // Not found Error
            //return new EmptyResult(); //Returns Blank Page
            //return RedirectToAction("Index", "Home", new { name = "the dude", code = 69 }); //Redirects to new Page with Query String parameters
        }

        //public ActionResult Index()
        //{
        //    var movie = new Movie() {ID = 6, Name = "Up in the Air"};
        //    return View(movie);
        //}

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        public ActionResult Index()
        {
            var randomMovieModel = new RandomMovieViewModel
            {
                Customers = _customers,
                Movies = _movies
            };

            return View(randomMovieModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year=" + year+"&month="+month);
        }

        public ActionResult MoviesList()
        {
            DataTable dt = MovieRepo.GetMovies();
            List<Movie> dtr =
                (from DataRow dr in dt.Rows
                select new Movie()
                {
                    FilmID = Convert.ToInt32(dr["FilmID"]),
                    FilmName = dr["FilmName"].ToString(),
                    FilmReleaseDate = Convert.ToDateTime(dr["FilmReleaseDate"].ToString()),
                    FilmDirectorID = Convert.ToInt32(dr["FilmDirectorID"]),
                    FilmSynopsis = dr["FilmSynopsis"].ToString()
                }).ToList();  //MovieRepo.GetMovies().AsEnumerable().ToList();
            return View(dtr);
        }
    }
}