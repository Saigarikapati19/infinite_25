using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Codechallenge8._1.Models
{
    public class MoviesContext
    {
        public class MovieContext : DbContext
        {
            public MovieContext() : base("name= connectstr") { }
            public DbSet<Movie> movie { get; set; }
        }
    }
}