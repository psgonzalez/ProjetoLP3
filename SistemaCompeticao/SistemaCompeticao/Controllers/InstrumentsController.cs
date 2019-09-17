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
    public class InstrumentsController : Controller
    {
        private CompeticaoDB db = new CompeticaoDB();

        // GET: Instruments
        public ActionResult Index()
        {
            var instrument = db.Instrument.Include(i => i.Music).Include(i => i.Member);
            return View(instrument.ToList());
        }

        // GET: Instruments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instrument instrument = db.Instrument.Find(id);
            if (instrument == null)
            {
                return HttpNotFound();
            }
            return View(instrument);
        }

        // GET: Instruments/Create
        public ActionResult Create()
        {
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title");
            ViewBag.Member_idMember = new SelectList(db.Member, "idMember", "Name");
            return View();
        }

        // POST: Instruments/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idInstrument,InstrumentType,Music_idMusic,Member_idMember")] Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                db.Instrument.Add(instrument);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", instrument.Music_idMusic);
            ViewBag.Member_idMember = new SelectList(db.Member, "idMember", "Name", instrument.Member_idMember);
            return View(instrument);
        }

        // GET: Instruments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instrument instrument = db.Instrument.Find(id);
            if (instrument == null)
            {
                return HttpNotFound();
            }
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", instrument.Music_idMusic);
            ViewBag.Member_idMember = new SelectList(db.Member, "idMember", "Name", instrument.Member_idMember);
            return View(instrument);
        }

        // POST: Instruments/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idInstrument,InstrumentType,Music_idMusic,Member_idMember")] Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instrument).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Music_idMusic = new SelectList(db.Music, "idMusic", "Title", instrument.Music_idMusic);
            ViewBag.Member_idMember = new SelectList(db.Member, "idMember", "Name", instrument.Member_idMember);
            return View(instrument);
        }

        // GET: Instruments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instrument instrument = db.Instrument.Find(id);
            if (instrument == null)
            {
                return HttpNotFound();
            }
            return View(instrument);
        }

        // POST: Instruments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Instrument instrument = db.Instrument.Find(id);
            db.Instrument.Remove(instrument);
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
