using A2ZMOVIES.Dtos;
using A2ZMOVIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace A2ZMOVIES.Controllers.Api
{
   
    public class MoviessController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviessController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]

        public IEnumerable<MovieDto> GetMovies()
        {
            var movie_query  =  _context.Movies
                                .Include(c => c.MovieGenreType)
                                .Where( c => c.NumberAvailable  > 0 );

            return movie_query.ToList().Select(Mapper.Map<Movies, MovieDto>);

        }
        [HttpGet]

        public MovieDto GetMovies(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            return Mapper.Map<Movies, MovieDto>(movie);

        }

        [HttpPost]
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult CreateMovies(MovieDto movieDto)
        {
            if (!ModelState.IsValid)

                return BadRequest();

            var movie = Mapper.Map<Movies>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto); 

        }


        [HttpPut]
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult UpdateMovies(MovieDto movieDto, int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (!ModelState.IsValid)
                return BadRequest();

            if (movieInDb == null)

                return NotFound();


            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();

            return Ok();
           
        }

        [HttpDelete]
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult DelectMovies(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)

                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();


            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }
    }



}
