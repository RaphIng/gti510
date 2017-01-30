using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CalendArt.Core.Domain;
using CalendArt.Infrastructure;
using CalendArt.Core.Repositories;
using CalendArt.Infrastructure.Repositories;

namespace CalendArt.Controllers
{
    public class CoursController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());

        // GET: Cours
        public ActionResult Index()
        {
            var cours = _unitOfWork.Cours.GetAll();
            return View(cours);
        }

        // GET: Cours/Details/5
        public ActionResult Details(int id)
        {
            Cours cours = _unitOfWork.Cours.Get(id);
            if (cours == null)
            {
                return HttpNotFound();
            }
            return View(cours);
        }

        // GET: Cours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sigle,Titre")] Cours cours)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Cours.Add(cours);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(cours);
        }

        // GET: Cours/Edit/5
        public ActionResult Edit(int id)
        {
            Cours cours = _unitOfWork.Cours.Get(id);
            if (cours == null)
            {
                return HttpNotFound();
            }
            return View(cours);
        }

        // POST: Cours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sigle,Titre")] Cours cours)
        {
            if (ModelState.IsValid)
            {
                // faire les modifications sur l'objet cours
                var editedCours = _unitOfWork.Cours.Get(cours.Id);
                editedCours.Sigle = cours.Sigle;
                editedCours.Titre = cours.Titre;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(cours);
        }

        // GET: Cours/Delete/5
        public ActionResult Delete(int id)
        {
            Cours cours = _unitOfWork.Cours.Get(id);
            if (cours == null)
            {
                return HttpNotFound();
            }
            return View(cours);
        }

        // POST: Cours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cours cours = _unitOfWork.Cours.Get(id);
            _unitOfWork.Cours.Remove(cours);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
