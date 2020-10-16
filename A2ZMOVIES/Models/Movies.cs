using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Models
{
    public class Movies

    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Please Enter Your Name")]
        public String Name { get; set;}

        [Display(Name = "Date Realsed")]
        public DateTime ReleaseDAte { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "Number in Stock Must be between 1 to 20")]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set;}

        public byte NumberAvailable {get ; set;}

        public MovieGenre MovieGenreType { get; set; }

        [Display(Name = "Movie Genre Type")]
        public Byte MovieGenreTypeId { get; set; }


    }
}