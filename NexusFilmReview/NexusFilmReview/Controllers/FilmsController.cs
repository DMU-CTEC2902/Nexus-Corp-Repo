using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NexusFilmReview.Models;

namespace NexusFilmReview.Controllers
{
    public class FilmsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: Films
        public ActionResult Index()
        {
            var films = db.Films.Include(f => f.Credit).Include(f => f.Genre).Include(f => f.User);
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
            ViewBag.CreditID = new SelectList(db.Credits, "CreditID", "CreditID");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreTitle");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserFirstName");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmID,FilmName,FilmDescription,ReleaseDate,Rating,UserID,CreditID,GenreID")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreditID = new SelectList(db.Credits, "CreditID", "CreditID", film.CreditID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreTitle", film.GenreID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserFirstName", film.UserID);
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
            ViewBag.CreditID = new SelectList(db.Credits, "CreditID", "CreditID", film.CreditID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreTitle", film.GenreID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserFirstName", film.UserID);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID,FilmName,FilmDescription,ReleaseDate,Rating,UserID,CreditID,GenreID")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreditID = new SelectList(db.Credits, "CreditID", "CreditID", film.CreditID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreTitle", film.GenreID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserFirstName", film.UserID);
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
