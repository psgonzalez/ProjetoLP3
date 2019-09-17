using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaCompeticao.Models;

namespace SistemaCompeticao.Controllers
{
    public class Artist_has_MusicController : Controller
    {
        private CompeticaoDB db = new CompeticaoDB();

        // GET: Artist_has_Music
        public ActionResult Index()
        {
            var artist_has_Music = db.Artist_has_Music.Include(a => a.Artist).Include(a => a.Music);
            return View(artist_has_Music.ToList());
        }

        // GET: Artist_has_Music/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Music artist_has_Music = db.Artist_has_Music.Find(id);
            if (artist_has_Music == null)
            {
                return HttpNotFound();
            }
            return View(artist_has_Music);
        }

        // GET: Artist_has_Music/Create
        public ActionResult Create()
        {
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name");
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title");
            return View();
        }

        // POST: Artist_has_Music/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Artist_idArtist,Music_idMusic,idArtist_has_Music")] Artist_has_Music artist_has_Music)
        {
            if (ModelState.IsValid)
            {
                db.Artist_has_Music.Add(artist_has_Music);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Music.Artist_idArtist);
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", artist_has_Music.Music_idMusic);
            return View(artist_has_Music);
        }

        // GET: Artist_has_Music/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Music artist_has_Music = db.Artist_has_Music.Find(id);
            if (artist_has_Music == null)
            {
                return HttpNotFound();
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Music.Artist_idArtist);
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", artist_has_Music.Music_idMusic);
            return View(artist_has_Music);
        }

        // POST: Artist_has_Music/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Artist_idArtist,Music_idMusic,idArtist_has_Music")] Artist_has_Music artist_has_Music)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist_has_Music).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Music.Artist_idArtist);
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", artist_has_Music.Music_idMusic);
            return View(artist_has_Music);
        }

        // GET: Artist_has_Music/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Music artist_has_Music = db.Artist_has_Music.Find(id);
            if (artist_has_Music == null)
            {
                return HttpNotFound();
            }
            return View(artist_has_Music);
        }

        // POST: Artist_has_Music/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist_has_Music artist_has_Music = db.Artist_has_Music.Find(id);
            db.Artist_has_Music.Remove(artist_has_Music);
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
