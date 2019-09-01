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
    public class MembersController : Controller
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        // GET: Members
        public ActionResult Index()
        {
            var member = db.Member.Include(m => m.Artist);
            return View(member.ToList());
        }

        // GET: Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Member.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name");
            return View();
        }

        // POST: Members/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idMember,Name,CPF,BirthDate,Artist_idArtist")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Member.Add(member);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", member.Artist_idArtist);
            return View(member);
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Member.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", member.Artist_idArtist);
            return View(member);
        }

        // POST: Members/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMember,Name,CPF,BirthDate,Artist_idArtist")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Artist_idArtist = new SelectList(db.Artist, "idArtist", "Name", member.Artist_idArtist);
            return View(member);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Member.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Member member = db.Member.Find(id);
            db.Member.Remove(member);
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
