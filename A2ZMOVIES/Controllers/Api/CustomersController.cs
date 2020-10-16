using A2ZMOVIES.Dtos;
using A2ZMOVIES.Models;
using AutoMapper;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2ZMOVIES.Controllers.Api
{
    public class CustomersController : ApiController
    {

        private ApplicationDbContext _context;

        public CustomersController()

        {
            _context = new ApplicationDbContext();
        }

        [HttpGet] 
       
        public IEnumerable<CustomerDto> GetCustomer()
        {
           return _context.Customers.Include(c => c.MemberShipType).ToList().Select(Mapper.Map<Customer , CustomerDto>); 

        }
        [HttpGet]
        public IHttpActionResult GetCustomer(int Id)
        {
            var customer =  _context.Customers.SingleOrDefault(c => c.id == Id);

            if (customer == null)
                return NotFound();
            
            return Ok(Mapper.Map<Customer , CustomerDto>(customer));
          
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer (CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            };

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.id = customer.id;

            return Created(new Uri(Request.RequestUri + "/" + customer.id), customerDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateCustomer(CustomerDto customerDto, int id)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            };

            var customerInDb = _context.Customers.SingleOrDefault(c => c.id == id);

            if (customerInDb == null)
            {
                return NotFound();

            };

            Mapper.Map(customerDto, customerInDb);


            _context.SaveChanges();
            return Ok();

        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Deletecustomers(int id)
        {
          

            var customerInDb = _context.Customers.SingleOrDefault(c => c.id == id);

            if (customerInDb == null)
            {
                return NotFound();
            };

            try
            {
                _context.Customers.Remove(customerInDb);
                _context.SaveChanges();

            }
            catch (UnauthorizedAccessException)
            {
                return BadRequest();
            }
           
            return Ok();
        }

    }
}
