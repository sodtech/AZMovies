using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace A2ZMOVIES.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string driversLicense { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    } 

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }

        public DbSet<MovieGenre> MovieGenres { get; set; }

        public DbSet<NewRentals> Rentals { get; set; }
        public ApplicationDbContext(): base("DefaultConnection")
        {
        }
    }
} 