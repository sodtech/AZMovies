using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace A2ZMOVIES.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }

        //[Required(ErrorMessage = "Please Enter Your Name")]
        public String Name { get; set; }

        public DateTime ReleaseDAte { get; set; }

        public DateTime DateAdded { get; set; }


        public byte NumberInStock { get; set; }

        public MovieGenreDto MovieGenreType { get; set; }

        public Byte MovieGenreTypeId { get; set; }


    }


}