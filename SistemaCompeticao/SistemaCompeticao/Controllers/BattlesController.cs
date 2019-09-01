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
    public class BattlesController : Controller
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        // GET: Battles
        public ActionResult Index()
        {
            var battle = db.Battle.Include(b => b.Event);
            return View(battle.ToList());
        }

        // GET: Battles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battle battle = db.Battle.Find(id);
            if (battle == null)
            {
                return HttpNotFound();
            }
            return View(battle);
        }

        // GET: Battles/Create
        public ActionResult Create()
        {
            ViewBag.Event_idEvent = new SelectList(db.Event, "idEvent", "Name");
            return View();
        }

        // POST: Battles/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idBattle,Name,BattleHour,Event_idEvent")] Battle battle)
        {
            if (ModelState.IsValid)
            {
                db.Battle.Add(battle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Event_idEvent = new SelectList(db.Event, "idEvent", "Name", battle.Event_idEvent);
            return View(battle);
        }

        // GET: Battles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battle battle = db.Battle.Find(id);
            if (battle == null)
            {
                return HttpNotFound();
            }
            ViewBag.Event_idEvent = new SelectList(db.Event, "idEvent", "Name", battle.Event_idEvent);
            return View(battle);
        }

        // POST: Battles/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idBattle,Name,BattleHour,Event_idEvent")] Battle battle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(battle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Event_idEvent = new SelectList(db.Event, "idEvent", "Name", battle.Event_idEvent);
            return View(battle);
        }

        // GET: Battles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Battle battle = db.Battle.Find(id);
            if (battle == null)
            {
                return HttpNotFound();
            }
            return View(battle);
        }

        // POST: Battles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Battle battle = db.Battle.Find(id);
            db.Battle.Remove(battle);
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
