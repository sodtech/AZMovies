using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using A2ZMOVIES.Models;


namespace A2ZMOVIES.viewMovieModel
{
    public class MovieView
    {
       public IEnumerable<MovieGenre> MovieGenres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public String Name { get; set; }

        public Byte? NumberAvailable { get; set; }

        [Display(Name = "Date Realsed")]
        public DateTime? ReleaseDAte { get; set; }

        public DateTime? DateAdded { get; set; }
       

        [Range(1, 20, ErrorMessage="Age Must be between 1 to 20")]
        public Byte? NumberInStock { get; set; }

        public MovieGenre MovieGenreType { get; set; }

        [Display(Name = "Movie Genre Type")]
        public Byte? MovieGenreTypeId { get; set; }

        public MovieView()
        {
            Id = 0;
        }

        public MovieView(Movies movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDAte = movie.ReleaseDAte;
            NumberInStock = movie.NumberInStock;
            MovieGenreTypeId = movie.MovieGenreTypeId;
            DateAdded = movie.DateAdded;
            NumberAvailable = movie.NumberAvailable; 
        }
    }
}

