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
using System.Diagnostics;

namespace CalendArt.Controllers
{
    public class EvenementController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());

        // GET: Evenements
        public ActionResult Index()
        {
            var evenements = _unitOfWork.Evenements.GetAll();
            if (evenements == null)
            {
                ViewBag.Message = "Vous n'avez aucun événement.";
            }
            return View(evenements);
        }

        // GET: Evenements/Details/5
        public ActionResult Details(int id)
        {
            Evenement evenement = _unitOfWork.Evenements.Get(id);
            if (evenement == null)
            {
                return HttpNotFound();
            }
            return View(evenement);
        }

        // GET: Evenements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evenements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titre,DateHeure,Location")] Evenement evenement)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Evenements.Add(evenement);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(evenement);
        }

        // GET: Evenements/Edit/5
        public ActionResult Edit(int id)
        {
            Evenement evenement = _unitOfWork.Evenements.Get(id);
            if (evenement == null)
            {
                return HttpNotFound();
            }
            return View(evenement);
        }

        // POST: Evenements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titre,DateHeure,Location")] Evenement evenement)
        {
            if (ModelState.IsValid)
            {
                // faire les modifications sur l'objet événement
                var editedEvenement = _unitOfWork.Evenements.Get(evenement.Id);
                editedEvenement.Titre= evenement.Titre;
                editedEvenement.DateHeure = evenement.DateHeure;
                editedEvenement.Location = evenement.Location;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(evenement);
        }

        // GET: Evenements/Delete/5
        public ActionResult Delete(int id)
        {
            Evenement evenement= _unitOfWork.Evenements.Get(id);
            if (evenement == null)
            {
                return HttpNotFound();
            }
            return View(evenement);
        }

        // POST: Evenements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evenement evenement = _unitOfWork.Evenements.Get(id);
            _unitOfWork.Evenements.Remove(evenement);
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
