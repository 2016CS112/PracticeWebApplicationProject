using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SecondVersion.Models;

namespace SecondVersion.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime  DateAddDataBase { get; set; }

        public Genre Genre { get; set;}

        public int GenreId { get; set; }

        public int NumberInStock { get; set; }
    }
}