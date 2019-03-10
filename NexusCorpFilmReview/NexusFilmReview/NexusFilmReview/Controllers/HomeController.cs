using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NexusFilmReview.Models;

namespace NexusFilmReview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FilmModel film = new FilmModel()
            {
                FilmName = "Brave 2",
                FilmDescription = "Determined to make her own path in life, Princess Merida defies a custom that brings chaos to her kingdom. Granted one wish, Merida must rely on her bravery and her archery skills to undo a beastly curse.",
                ReleaseDate = Convert.ToDateTime("12/06/2015"),
                Rating = 9 
            };

            return View(film);
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