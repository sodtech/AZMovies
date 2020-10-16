using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A2ZMOVIES.Models;

namespace A2ZMOVIES.ViewModel
{
    public class CosumerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }

        public Customer Customers { get; set; }
    }
    
}