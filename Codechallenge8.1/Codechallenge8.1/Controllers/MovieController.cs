using Codechallenge8._1.Models;
using Codechallenge8._1.Repository;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Codechallenge8._1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        IMovieRepositry _mv = null;
        public MovieController()
        {
            _mv = new MovieRepository();
        }
        public ActionResult Index()
        {
            var mvd = _mv.GetAll();
            return View(mvd);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                _mv.Create(m);
                return RedirectToAction("Index");
            }
            return View(m);
        }

        public ActionResult Edit(int id)
        {
            var movie = _mv.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                _mv.Edit(m);
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }
        public ActionResult Delete(int id)
        {
            var movie = _mv.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _mv.Delete(id);
            return RedirectToAction("Index");
        }


    }
}