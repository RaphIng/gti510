using System.Web.Mvc;
using CalendArt.Core.Domain;
using CalendArt.Infrastructure;

namespace CalendArt.Controllers
{
    public class EventController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());

        // GET: Events
        public ActionResult Index()
        {
            var events = _unitOfWork.Events.GetAll();
            if (events == null)
            {
                ViewBag.Message = "Vous n'avez aucun événement.";
            }
            return View(events);
        }

        // GET: Events/Details/5
        public ActionResult Details(int id)
        {
            Event @event = _unitOfWork.Events.Get(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,Title,StartDateTime,EndDateTime,Location")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Events.Add(@event);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            Event @event = _unitOfWork.Events.Get(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,Title,StartDateTime,EndDateTime,Location")] Event @event)
        {
            if (ModelState.IsValid)
            {
                // Edit the event
                var editedEvenement = _unitOfWork.Events.Get(@event.EventId);
                editedEvenement.Title= @event.Title;
                editedEvenement.StartDateTime = @event.StartDateTime;
                editedEvenement.EndDateTime = @event.EndDateTime;
                editedEvenement.Location = @event.Location;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int id)
        {
            Event @event= _unitOfWork.Events.Get(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = _unitOfWork.Events.Get(id);
            _unitOfWork.Events.Remove(@event);
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
