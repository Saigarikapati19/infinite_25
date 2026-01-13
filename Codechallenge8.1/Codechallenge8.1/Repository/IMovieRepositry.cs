using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using Codechallenge8._1.Models;


namespace Codechallenge8._1.Repository
{
    public interface IMovieRepositry
    {
        IEnumerable<Movie> GetAllMoviesByYear(int year);
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void Create(Movie movie);
        void Edit(Movie movie);
        void Delete(int id);
        IEnumerable<Movie> GetAllMoviesByDirector(string directorName);
    }
}