using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NexusCorpFilmReview.Models;

namespace NexusCorpFilmReview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ReviewModel review = new ReviewModel()
            {
                ReviewID = 1,
                Review = "This was an excelent film! Loved it",
                ReviewDateAdded = DateTime.Now.Date,
                UserID = 23,
                FilmID = 13

            };

            return View(review);
        }
    }
}