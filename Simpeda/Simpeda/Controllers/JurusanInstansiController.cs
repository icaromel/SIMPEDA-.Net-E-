using System;
using System.Collections.Generic;
//using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Simpeda;

namespace Simpeda.Controllers
{
    public class JurusanInstansiController : Controller
    {
        private SimpedaEntities db = new SimpedaEntities();

        // GET: /JurusanInstansi/
        public ActionResult Index()
        {
            return View(db.JurusanInstansi.ToList());
        }

        // GET: /JurusanInstansi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JurusanInstansi jurusaninstansi = db.JurusanInstansi.Find(id);
            if (jurusaninstansi == null)
            {
                return HttpNotFound();
            }
            return View(jurusaninstansi);
        }

        // GET: /JurusanInstansi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /JurusanInstansi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="idJurusan,namaJurusan,alamatJurusan,teleponJurusan")] JurusanInstansi jurusaninstansi)
        {
            if (ModelState.IsValid)
            {
                db.JurusanInstansi.Add(jurusaninstansi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jurusaninstansi);
        }

        // GET: /JurusanInstansi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JurusanInstansi jurusaninstansi = db.JurusanInstansi.Find(id);
            if (jurusaninstansi == null)
            {
                return HttpNotFound();
            }
            return View(jurusaninstansi);
        }

        // POST: /JurusanInstansi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="idJurusan,namaJurusan,alamatJurusan,teleponJurusan")] JurusanInstansi jurusaninstansi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jurusaninstansi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jurusaninstansi);
        }

        // GET: /JurusanInstansi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JurusanInstansi jurusaninstansi = db.JurusanInstansi.Find(id);
            if (jurusaninstansi == null)
            {
                return HttpNotFound();
            }
            return View(jurusaninstansi);
        }

        // POST: /JurusanInstansi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JurusanInstansi jurusaninstansi = db.JurusanInstansi.Find(id);
            db.JurusanInstansi.Remove(jurusaninstansi);
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
