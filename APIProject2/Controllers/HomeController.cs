using APIProject2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIProject2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MovieDB movie = MovieDAL.GetMovie();
            var model = new MovieModel();
            model.Movies = new List<MovieDB>();
            model.Movies.Add(movie);
            return View(model);
        }

        public ActionResult Search(MovieModel model)
        {
            model.Movies = MovieDAL.SearchByTitle(model.Title);

            return View("Index", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}