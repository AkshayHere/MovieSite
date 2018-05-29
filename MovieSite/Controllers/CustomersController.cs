using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSite.Models;
using MovieSite.ViewModels;
using System.Data.SqlClient;

namespace MovieSite.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> _customerList = new List<Customer>()
        {
            new Customer() { Name = "The Dude", Id = 1},
            new Customer() { Name = "Walter", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var rndm = new RandomMovieViewModel()
            {
                Customers = _customerList
            };
            return View(rndm);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _customerList.Find(r => r.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}