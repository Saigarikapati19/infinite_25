using Codechallenge8._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Codechallenge8._1.Models.MoviesContext;

namespace Codechallenge8._1.Repository
{
    public class MovieRepository : IMovieRepositry
    {
        MovieContext db;
        public MovieRepository()
        {
            db = new MovieContext();
        }

        public void Edit(Movie movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMoviesByYear(int year)
        {
            return db.movie.Where(m => m.DateofRelease.Year == year).ToList();
        }

        public void Create(Movie movie)
        {

            db.movie.Add(movie);
            db.SaveChanges();
        }
        public IEnumerable<Movie> GetAll()
        {
            return db.movie.ToList();
        }
        public Movie GetById(int id)
        {
            return db.movie.Find(id);
        }
        public void Delete(int id)
        {
            Movie movie = db.movie.Find(id);
            if (movie != null)
            {
                db.movie.Remove(movie);
                db.SaveChanges();
            }
        }
        public IEnumerable<Movie> GetAllMoviesByDirector(string directorName)
        {
            return db.movie
                     .Where(m => m.Directorname == directorName)
                     .ToList();
        }
    }
}
