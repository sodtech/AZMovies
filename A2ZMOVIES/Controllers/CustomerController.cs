//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using A2ZMOVIES.Models;
//using A2ZMOVIES.viewMode;

//namespace A2ZMOVIES.Controllers
//{
//    public class CustomerController : Controller
//    {
//        // GET: Customer

//        public ActionResult index(List<Customer> Customer)
//        {
//            var customer = new List<Customer>()
//            {
//                new Customer { id = 1 , Name = "sodiq"},
//                new Customer { id = 1 , Name = "Tobi"},
//                new Customer { id = 1 , Name = "Jubril"}
//            };

//            var ViewModel = new RanViewModel
//            {
//                Customer = customer
//            };

//            return View(ViewModel);
//        }

//    }
//}

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using A2ZMOVIES.Models;
using A2ZMOVIES.ViewModel;



namespace A2ZMOVIES.Controllers
{
    //[Route("Customer/costomer/{Name}")]
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        //public object MemberShipTypes { get; private set; }

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {

            var membershiptype = _context.MemberShipTypes.ToList();

            var viewModel = new CosumerViewModel
            {
                MemberShipTypes = membershiptype
            };

            return View(viewModel);
        }

        public ViewResult Index()
        {
            //var customers = _context.Customers.Include(c => c.MemberShipType).ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CosumerViewModel customer )
        {
           if (!ModelState.IsValid)
            {
                var ViewModel = new CosumerViewModel
                {
                    Customers = customer.Customers,

                    MemberShipTypes = _context.MemberShipTypes.ToList()
                };

                return View("NewCustomer" , ViewModel);
            }

            if (customer.Customers.id == 0)
            {
                _context.Customers.Add(customer.Customers);
            }
            else
            {
                var getCustomerDetails = _context.Customers.Single(c => c.id == customer.Customers.id);

                getCustomerDetails.IsSubcribedToNewsletter = customer.Customers.IsSubcribedToNewsletter;
                getCustomerDetails.Name = customer.Customers.Name;
                getCustomerDetails.MemberShipTypeId= customer.Customers.MemberShipTypeId;
                getCustomerDetails.DateOfBrith = customer.Customers.DateOfBrith ;
            } 
             
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.id == id);

            return View(customer);

        }
        public ActionResult Edit(int id)
        {

            if (id == 0)
            {

                var viewModel1 = new CosumerViewModel
                {
                    Customers = new Customer(),
                    MemberShipTypes = _context.MemberShipTypes.ToList()
                };

                 return View("NewCustomer", viewModel1);
            }
            var customer = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CosumerViewModel
            {
                Customers = _context.Customers.SingleOrDefault(c => c.id == id),
                MemberShipTypes = _context.MemberShipTypes.ToList()
             };

            return View("NewCustomer", viewModel ); 
        }   
    } 
        
}
     