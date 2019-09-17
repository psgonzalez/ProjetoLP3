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
    public class Artist_has_CompetitionController : Controller
    {
        private CompeticaoDB db = new CompeticaoDB();

        // GET: Artist_has_Competition
        public ActionResult Index()
        {
            var artist_has_Competition = db.Artist_has_Competition.Include(a => a.Artist).Include(a => a.Battle);
            return View(artist_has_Competition.ToList());
        }

        // GET: Artist_has_Competition/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Competition artist_has_Competition = db.Artist_has_Competition.Find(id);
            if (artist_has_Competition == null)
            {
                return HttpNotFound();
            }
            return View(artist_has_Competition);
        }

        // GET: Artist_has_Competition/Create
        public ActionResult Create()
        {
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name");
            ViewBag.Battle_idBattle = new SelectList(db.Battle, "idBattle", "Name");
            return View();
        }

        // POST: Artist_has_Competition/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Artist_idArtist,Battle_idBattle,idArtist_has_Competition")] Artist_has_Competition artist_has_Competition)
        {
            if (ModelState.IsValid)
            {
                db.Artist_has_Competition.Add(artist_has_Competition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Competition.Artist_idArtist);
            ViewBag.Battle_idBattle = new SelectList(db.Battle, "idBattle", "Name", artist_has_Competition.Battle_idBattle);
            return View(artist_has_Competition);
        }

        // GET: Artist_has_Competition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Competition artist_has_Competition = db.Artist_has_Competition.Find(id);
            if (artist_has_Competition == null)
            {
                return HttpNotFound();
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Competition.Artist_idArtist);
            ViewBag.Battle_idBattle = new SelectList(db.Battle, "idBattle", "Name", artist_has_Competition.Battle_idBattle);
            return View(artist_has_Competition);
        }

        // POST: Artist_has_Competition/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Artist_idArtist,Battle_idBattle,idArtist_has_Competition")] Artist_has_Competition artist_has_Competition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist_has_Competition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", artist_has_Competition.Artist_idArtist);
            ViewBag.Battle_idBattle = new SelectList(db.Battle, "idBattle", "Name", artist_has_Competition.Battle_idBattle);
            return View(artist_has_Competition);
        }

        // GET: Artist_has_Competition/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist_has_Competition artist_has_Competition = db.Artist_has_Competition.Find(id);
            if (artist_has_Competition == null)
            {
                return HttpNotFound();
            }
            return View(artist_has_Competition);
        }

        // POST: Artist_has_Competition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist_has_Competition artist_has_Competition = db.Artist_has_Competition.Find(id);
            db.Artist_has_Competition.Remove(artist_has_Competition);
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
