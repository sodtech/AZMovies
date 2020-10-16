using A2ZMOVIES.Dtos;
using A2ZMOVIES.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2ZMOVIES.Controllers.Api
{
    public class NewRentalController : ApiController
    {
       private ApplicationDbContext _context;

       public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

       [HttpPost]
       public IHttpActionResult createNewRental(NewRentalDto NewRental)
       {
           var customer = _context.Customers.Include(c => c.MemberShipType).Single(
               c => c.id == NewRental.CustomerId);

           var movies = _context.Movies.Where(
               m => NewRental.MoviesIds.Contains(m.Id));

           foreach (var movie in movies)
           {
               if (movie.NumberAvailable == 0)
                   return BadRequest("Movie is not available");
               movie.NumberAvailable--;
               movie.NumberInStock--;
                var rental = new NewRentals
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                };

               _context.Rentals.Add(rental);

           }
           _context.SaveChanges();

           return Ok();
       }

          [HttpGet]
        public IEnumerable<NewRentals> GetMoviesTransactions()
		{
            var MoviesTransactions = _context.Rentals
                                            .Include(c => c.Customer)
                                            .Include(c => c.Movie).ToList();

            return MoviesTransactions;
		}
    }
}
