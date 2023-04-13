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
    public class CadastroSemestreController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: CadastroSemestre
        public ViewResult Index()
        {
            return View(db.CadastroSemestre.ToList());
        }

        // GET: CadastroSemestre/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSemestre cadastroSemestre = db.CadastroSemestre.Find(id);
            if (cadastroSemestre == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSemestre);
        }

        // GET: CadastroSemestre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroSemestre/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PeriodoLetivo,Campus,Curso,MatrizCurricular,Semestre")] CadastroSemestre cadastroSemestre)
        {
            if (ModelState.IsValid)
            {
                db.CadastroSemestre.Add(cadastroSemestre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastroSemestre);
        }

        // GET: CadastroSemestre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSemestre cadastroSemestre = db.CadastroSemestre.Find(id);
            if (cadastroSemestre == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSemestre);
        }

        // POST: CadastroSemestre/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PeriodoLetivo,Campus,Curso,MatrizCurricular,Semestre")] CadastroSemestre cadastroSemestre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastroSemestre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastroSemestre);
        }

        // GET: CadastroSemestre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSemestre cadastroSemestre = db.CadastroSemestre.Find(id);
            if (cadastroSemestre == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSemestre);
        }

        // POST: CadastroSemestre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadastroSemestre cadastroSemestre = db.CadastroSemestre.Find(id);
            db.CadastroSemestre.Remove(cadastroSemestre);
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
