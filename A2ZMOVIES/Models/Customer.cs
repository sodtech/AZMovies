using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please Enter Your a Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Is18VerificationAge]
        [Display(Name = "Date Of Brith")]
        public DateTime? DateOfBrith { get; set; }

        [Display(Name = "Subcribe To NewsLetter")]
        public bool IsSubcribedToNewsletter { get; set; }

        [Display(Name = "MemberShip Type")]
        public MemberShipType MemberShipType { get; set; }

        public int MemberShipTypeId { get; set; }
     
    }
} 