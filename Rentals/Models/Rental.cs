using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rentals.Models
{
    public class Rental
    {
        [Key]
        public int RentalID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        [ForeignKey ("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey ("Movie")]
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }
    }
}