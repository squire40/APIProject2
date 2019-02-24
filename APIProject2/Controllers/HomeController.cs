﻿using APIProject2.Models;
using MovieAPI.Models;
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

            return View(movie);
        }

        public ActionResult Search(MovieModel model)
        {
            model.Movies = MovieDAL.SearchByTitle(model.Title);

            return View(model);
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