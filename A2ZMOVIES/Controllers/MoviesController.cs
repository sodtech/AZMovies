using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A2ZMOVIES.Models;
using A2ZMOVIES.viewMovieModel;


namespace A2ZMOVIES.Controllers
{
    
    public class MoviesController : Controller
    {

        private ApplicationDbContext _Context;

        public MoviesController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }

        public ActionResult Index()
        {
            //var movies = _Context.Movies.Include(c => c.MovieGenreType).ToList();

            if (User.IsInRole(RoleName.canManageMovies))
                return View("list");
            return View("readOnlyList");

        }

        [Authorize(Roles = RoleName.canManageMovies)]
        public ActionResult ToCreateUpdate(int id)

        {
  
            var movie = _Context.Movies.SingleOrDefault(c => c.Id == id);

            if (id == 0)
            {
                var ViewModel1= new MovieView()
                {
                    MovieGenres = _Context.MovieGenres.ToList()
                };

                return View("ToCreateUpdate", ViewModel1);
            }

            var ViewModel = new MovieView()
            {
                Name = movie.Name,
                MovieGenreTypeId = movie.MovieGenreTypeId,
                NumberInStock = movie.NumberInStock,
                Id = movie.Id,
                ReleaseDAte = movie.ReleaseDAte,
                DateAdded = DateTime.Now,
                MovieGenres = _Context.MovieGenres.ToList()
            };

            return View("ToCreateUpdate", ViewModel);

        }

         [Authorize(Roles = RoleName.canManageMovies)]
        public ActionResult SaveUpdateMovie(Movies movie)
        {
            movie.NumberAvailable = movie.NumberInStock;

            if (!ModelState.IsValid)
            {
                var ViewModel = new MovieView()
                {
                    Name = movie.Name,
                    MovieGenreTypeId = movie.MovieGenreTypeId,
                    NumberInStock = movie.NumberInStock,
                    Id = movie.Id,
                    ReleaseDAte = movie.ReleaseDAte,
                    DateAdded = DateTime.Now,
                    MovieGenres = _Context.MovieGenres.ToList()
                };


                return View("ToCreateUpdate", ViewModel);
            }
            if (movie.Id == 0)
                _Context.Movies.Add(movie);
            else
            {
                var movieInDb = _Context.Movies.Single(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDAte = movie.ReleaseDAte;
                movieInDb.NumberAvailable = movie.NumberInStock;
                movieInDb.MovieGenreTypeId = movie.MovieGenreTypeId;
            }
            _Context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Details(int id)
        {
            var movies = _Context.Movies.Include(c => c.MovieGenreType).SingleOrDefault(c => c.Id == id);

             if (movies == null )
                return HttpNotFound();
            

            return View(movies);
        }

    }
}