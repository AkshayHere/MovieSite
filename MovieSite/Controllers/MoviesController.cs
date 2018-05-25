﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieSite.Models;
using MovieSite.ViewModels;

namespace MovieSite.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {ID = 51,Name = "The Big Lebowski"};

            var Customers = new List<Customer>
            {
                new Customer { Name = "Darth Vader", Id = 51},
                new Customer { Name = "Yoda", Id = 161},
                new Customer { Name = "Chebacca", Id = 6},
            };

            var randomMovieModel = new RandomMovieViewModel
            {
                Customers = Customers,
                Movie = movie
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

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year=" + year+"&month="+month);
        }
    }
}