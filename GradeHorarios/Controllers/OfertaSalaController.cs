using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GradeHorarios.DAL;
using GradeHorarios.Models;

namespace GradeHorarios.Controllers
{
    public class OfertaSalaController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: OfertaSala
        public ActionResult Index()
        {
            var enrollments = db.Enrollments.Include(o => o.CadastroSala).Include(o => o.CadastroSemestre);
            return View(enrollments.ToList());
        }

        // GET: OfertaSala/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaSala ofertaSala = db.Enrollments.Find(id);
            if (ofertaSala == null)
            {
                return HttpNotFound();
            }
            return View(ofertaSala);
        }

        // GET: OfertaSala/Create
        public ActionResult Create()
        {
            ViewBag.CadastroSalaID = new SelectList(db.CadastroSala, "ID", "NomeSala");
            ViewBag.CadastroSemestreID = new SelectList(db.CadastroSemestre, "ID", "PeriodoLetivo");
            return View();
        }

        // POST: OfertaSala/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfertaSalaID,CadastroSalaID,CadastroSemestreID")] OfertaSala ofertaSala)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(ofertaSala);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CadastroSalaID = new SelectList(db.CadastroSala, "ID", "NomeSala", ofertaSala.CadastroSalaID);
            ViewBag.CadastroSemestreID = new SelectList(db.CadastroSemestre, "ID", "PeriodoLetivo", ofertaSala.CadastroSemestreID);
            return View(ofertaSala);
        }

        // GET: OfertaSala/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaSala ofertaSala = db.Enrollments.Find(id);
            if (ofertaSala == null)
            {
                return HttpNotFound();
            }
            ViewBag.CadastroSalaID = new SelectList(db.CadastroSala, "ID", "NomeSala", ofertaSala.CadastroSalaID);
            ViewBag.CadastroSemestreID = new SelectList(db.CadastroSemestre, "ID", "PeriodoLetivo", ofertaSala.CadastroSemestreID);
            return View(ofertaSala);
        }

        // POST: OfertaSala/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfertaSalaID,CadastroSalaID,CadastroSemestreID")] OfertaSala ofertaSala)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ofertaSala).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CadastroSalaID = new SelectList(db.CadastroSala, "ID", "NomeSala", ofertaSala.CadastroSalaID);
            ViewBag.CadastroSemestreID = new SelectList(db.CadastroSemestre, "ID", "PeriodoLetivo", ofertaSala.CadastroSemestreID);
            return View(ofertaSala);
        }

        // GET: OfertaSala/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaSala ofertaSala = db.Enrollments.Find(id);
            if (ofertaSala == null)
            {
                return HttpNotFound();
            }
            return View(ofertaSala);
        }

        // POST: OfertaSala/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfertaSala ofertaSala = db.Enrollments.Find(id);
            db.Enrollments.Remove(ofertaSala);
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
