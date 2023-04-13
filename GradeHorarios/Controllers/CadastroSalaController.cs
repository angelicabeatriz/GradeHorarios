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
    public class CadastroSalaController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: CadastroSala
        public ViewResult Index()
        {
            return View(db.CadastroSala.ToList());
        }

        // GET: CadastroSala/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSala cadastroSala = db.CadastroSala.Find(id);
            if (cadastroSala == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSala);
        }

        // GET: CadastroSala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroSala/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NomeSala,Campus,Bloco,Descricao,NumeroPessoas,EnrollmentDate")] CadastroSala cadastroSala)
        {
            if (ModelState.IsValid)
            {
                db.CadastroSala.Add(cadastroSala);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastroSala);
        }

        // GET: CadastroSala/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSala cadastroSala = db.CadastroSala.Find(id);
            if (cadastroSala == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSala);
        }

        // POST: CadastroSala/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NomeSala,Campus,Bloco,Descricao,NumeroPessoas,EnrollmentDate")] CadastroSala cadastroSala)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastroSala).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastroSala);
        }

        // GET: CadastroSala/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadastroSala cadastroSala = db.CadastroSala.Find(id);
            if (cadastroSala == null)
            {
                return HttpNotFound();
            }
            return View(cadastroSala);
        }

        // POST: CadastroSala/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadastroSala cadastroSala = db.CadastroSala.Find(id);
            db.CadastroSala.Remove(cadastroSala);
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
