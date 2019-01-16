using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SecondVersion.Models;
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
    }
}