using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NexusCorpFilmReviews.Models;

//Namespace for the film controller class
namespace NexusCorpFilmReviews.Controllers
{
    //public class body for the film controller class. All the code for this controller class needs to be inside this public body fucntion
    public class FilmsController : Controller
    {
        //Create a private variable called db connecting it to the film context
        private FilmContext db = new FilmContext();

        // public action result function for the index, which returns a view of all the connected keys to the film class 
        public ActionResult Index()
        {
            //Using ViewBag, retrieve the username that matches the username stored in the database
            ViewBag.UserName = User.Identity.GetUserId();

            var films = db.Films.Include(f => f.Actor).Include(f => f.Director).Include(f => f.Genre);
            return View(films.ToList());
        }

        // GET: Films/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorFirstName");
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorFirstName");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmId,GenreId,ActorId,DirectorId,FilmName,FilmDescription,ReleaseDate,Rating,UserName,FilmImage")] Film film)
        {
            if (ModelState.IsValid)
            {
                //getting the user name from the data base and storing it in the UserName Variable
                film.UserName = User.Identity.GetUserId();
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorFirstName", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorFirstName", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            return View(film);
        }

        // GET: Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorFirstName", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorFirstName", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmId,GenreId,ActorId,DirectorId,FilmName,FilmDescription,ReleaseDate,Rating,UserName,FilmImage")] Film film)
        {
            if (ModelState.IsValid)
            {
                //getting the user name from the data base and storing it in the UserName Variable
                film.UserName = User.Identity.GetUserId();
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorFirstName", film.ActorId);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorFirstName", film.DirectorId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Protected ovveride void function for removing the film from the database  
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
