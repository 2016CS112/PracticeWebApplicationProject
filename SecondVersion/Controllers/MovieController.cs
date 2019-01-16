using SecondVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace SecondVersion.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _db;

        public MovieController()
        {
            _db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var Movie = _db.Movies.Include(x => x.Genre).ToList();
            return View(Movie);
        }

        [Route("movie/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var Movie = _db.Movies.Include(x => x.Genre).SingleOrDefault(f => f.Id == id);
            if(Movie==null)
            {
                return HttpNotFound();
            }
            return View(Movie);
        }
    }
}