using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Dtos
{
    public class CustomerDto
    {
        public int id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
  
        public bool IsSubcribedToNewsletter { get; set; }

        public MemberShipTypeDto MemberShipType { get; set; }

        public int MemberShipTypeId { get; set; }
     
        //[Is18VerificationAge]
        public DateTime? DateOfBrith { get; set; }

    }
}