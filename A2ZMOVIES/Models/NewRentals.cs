using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Models
{
    public class NewRentals
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public  Movies Movie { get; set; }
        public int MovieId { get; set; }

        public DateTime DateRented {get; set;}

        public DateTime? DateReturned { get; set; }
    }
}