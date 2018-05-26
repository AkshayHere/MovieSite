using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSite.Models;
using MovieSite.ViewModels;

namespace MovieSite.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> CustomerList = new List<Customer>()
        {
            new Customer() { Name = "The Dude", Id = 1},
            new Customer() { Name = "Walter", Id = 2}
        };
        // GET: Customers
        public ActionResult Index()
        {
            var rndm = new RandomMovieViewModel()
            {
                Customers = CustomerList
            };
            return View(rndm);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var Customer = CustomerList.Find(r => r.Id == id);
            if (Customer == null)
                return HttpNotFound();

            return View(Customer);
        }
    }
}