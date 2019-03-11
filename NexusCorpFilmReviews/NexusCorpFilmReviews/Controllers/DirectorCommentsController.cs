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
    public class DirectorCommentsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: DirectorComments
        public ActionResult Index()
        {
            return View(db.DirectorComments.ToList());
        }

        // GET: DirectorComments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            return View(directorComment);
        }

        // GET: DirectorComments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DirectorComments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DirectorCommentId,DirectorCommentContent,DirectorCommentDateAdded,UserName")] DirectorComment directorComment)
        {
            if (ModelState.IsValid)
            {
                db.DirectorComments.Add(directorComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(directorComment);
        }

        // GET: DirectorComments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            return View(directorComment);
        }

        // POST: DirectorComments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DirectorCommentId,DirectorCommentContent,DirectorCommentDateAdded,UserName")] DirectorComment directorComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(directorComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(directorComment);
        }

        // GET: DirectorComments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            return View(directorComment);
        }

        // POST: DirectorComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DirectorComment directorComment = db.DirectorComments.Find(id);
            db.DirectorComments.Remove(directorComment);
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
