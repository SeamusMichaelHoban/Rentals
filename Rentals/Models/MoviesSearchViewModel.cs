using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentals.Models
{
    public class MoviesSearchViewModel
    {

        public string SearchText { get; set; }
        public List<Movie> Results { get; set; }


    }
}