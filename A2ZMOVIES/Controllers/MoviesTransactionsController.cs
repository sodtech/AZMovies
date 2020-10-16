using A2ZMOVIES.Models;
using A2ZMOVIES.viewModelTransaction;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A2ZMOVIES.Controllers
{
	public class MoviesTransactionsController : Controller
	{
		// GET: /MoviesTransactions/
		private ApplicationDbContext _Context;

		public MoviesTransactionsController()
		{
			_Context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_Context.Dispose();
		}

		public ActionResult Index()
		{
            //var MoviesTransactions = _Context.Rentals.Include(c => c.Customer).Include(c => c.Movie).ToList();


            return View();
		}
	}
}