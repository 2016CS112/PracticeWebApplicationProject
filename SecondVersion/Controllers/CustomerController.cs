using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SecondVersion.Models;
using SecondVersion.ViewModel;
namespace SecondVersion.Controllers
{

    public class CustomerController : Controller
    {

        private ApplicationDbContext db;

        public CustomerController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = db.Customers.Include(c => c.MemberShipType).ToList();
            return View(customers);
        }


        public ActionResult New()
        {
            var member = db.MemberShipTypes.ToList();

            var ViewModel = new NewCustomerViewModel
            {
                MemberShipTypes = member
            };
            return View(ViewModel);
        }

        

        [HttpPost]
        public ActionResult Create(Customer  customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("index", "Customer");
        }

       

        [Route("customer/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var customer = db.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        public ActionResult Edit(int id)
        {
            var customer = db.Customers.SingleOrDefault(v => v.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MemberShipTypes = db.MemberShipTypes.ToList()
            };

            return View("New" , viewModel);
        }
    }
}

