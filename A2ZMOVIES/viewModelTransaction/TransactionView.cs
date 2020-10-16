using A2ZMOVIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.viewModelTransaction
{
    public class TransactionView

    {
        public IEnumerable<Customer> Customer { get; set; }

        public IEnumerable<Movies> Movies { get; set; }



    }
}