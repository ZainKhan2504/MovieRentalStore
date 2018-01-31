using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MovieRentalStore.Models;

namespace MovieRentalStore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}