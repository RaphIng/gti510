using CalendArt.Core.Domain;
using CalendArt.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CalendArt.Controllers
{
    public class AlertController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());
        //
        // GET: /Alert/
        public ActionResult Index()
        {
            var alert = _unitOfWork.Alert.GetAll();
            return View();
        }

        //
        // GET: /Alert/Details/5
        public ActionResult Details(int id)
        {
            Alert alert = _unitOfWork.Alert.Get(id);
            if (alert == null)
            {
                return HttpNotFound();
            }
            return View(alert);
        }

        //
        // GET: /Alert/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Alert/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Debut,Fin,Rappel")] Alert alert)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Alert.Add(alert);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }


            return View(alert);
        }

        //
        // GET: /Alert/Edit/5
        public ActionResult Edit(int id)
        {
            Alert alert = _unitOfWork.Alert.Get(id);
            if (alert == null)
            {
                return HttpNotFound();
            }
            return View(alert);
        }

        //      
        // POST: /Alert/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Debut,Fin,Rappel")] Alert alert)
        {

            if (ModelState.IsValid)
            {
                // faire les modifications sur l'objet Alert
                var editedAlert = _unitOfWork.Alert.Get(alert.Id);
                editedAlert.Debut = alert.Debut;
                editedAlert.Fin = alert.Fin;
                editedAlert.Rappel = alert.Rappel;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(alert);

        }

        //
        // GET: /Alert/Delete/5
        public ActionResult Delete(int id)
        {
            Alert alert = _unitOfWork.Alert.Get(id);
            if (alert == null)
            {
                return HttpNotFound();
            }
            return View(alert);
        }

        //
        // POST: /Alert/Delete/5
        [HttpPost, ActionName("Alert")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alert alert = _unitOfWork.Alert.Get(id);
            _unitOfWork.Alert.Remove(alert);
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
