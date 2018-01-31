using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalStore.Models;
using MovieRentalStore.ViewModels;

namespace MovieRentalStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customers>
            {
                new Customers {Name = "Customer 1" },
                new Customers {Name = "Customer 2" }
            };
            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(ViewModel);
        }
    }
}