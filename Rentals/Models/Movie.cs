using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rentals.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Rental>Rentals { get; set; }

    }
}