using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A2ZMOVIES.Models
{
    public class Is18VerificationAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == 1 || customer.MemberShipTypeId == 0)
                return ValidationResult.Success;
           
            if (customer.DateOfBrith == null)
              return new ValidationResult("Please Enter Your Brith Day");
            

            var isOfAge = DateTime.Now.Year - customer.DateOfBrith.Value.Year;

            if ( isOfAge >= 18)
                return ValidationResult.Success;
            else
                return new ValidationResult("You Must be 18 to Subcribe for MemeberShip");

        }
    }
    
}