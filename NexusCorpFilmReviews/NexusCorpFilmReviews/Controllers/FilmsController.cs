using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NexusCorpFilmReviews.Models;

namespace NexusCorpFilmReviews.Controllers
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
            ViewBag.CreditId = new SelectList(db.Credits, "CreditId", "CreditId");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType");
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserFirstName");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmId,FilmName,FilmDescription,ReleaseDate,Rating,UserId,CreditId,GenreId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreditId = new SelectList(db.Credits, "CreditId", "CreditId", film.CreditId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserFirstName", film.UserId);
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
            ViewBag.CreditId = new SelectList(db.Credits, "CreditId", "CreditId", film.CreditId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserFirstName", film.UserId);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmId,FilmName,FilmDescription,ReleaseDate,Rating,UserId,CreditId,GenreId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreditId = new SelectList(db.Credits, "CreditId", "CreditId", film.CreditId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "GenreType", film.GenreId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserFirstName", film.UserId);
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
