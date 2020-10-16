using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Models
{
    public class MemberShipType
    {
       
        public int Id { get; set; }
        public String Name { get; set; }
        public string SignUpFee { get; set; }
        public string DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
    }
}