using CalendArt.Core.Domain;
using CalendArt.Infrastructure;
using System.Web.Mvc;


namespace CalendArt.Controllers
{
    public class ReminderController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());
        //
        // GET: /Reminder/
        public ActionResult Index()
        {
            var reminders = _unitOfWork.Reminders.GetAll();
            return View(reminders);
        }

        //
        // GET: /Reminder/Details/5
        public ActionResult Details(int id)
        {
            Reminder reminder = _unitOfWork.Reminders.Get(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            return View(reminder);
        }

        //
        // GET: /Reminder/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reminder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReminderId,TimeBeforeEvent,EventId,ReminderTypeId")] Reminder reminder)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Reminders.Add(reminder);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }


            return View(reminder);
        }

        //
        // GET: /Reminder/Edit/5
        public ActionResult Edit(int id)
        {
            Reminder reminder = _unitOfWork.Reminders.Get(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            return View(reminder);
        }

        //      
        // POST: /Reminder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReminderId,TimeBeforeEvent,EventId,ReminderTypeId")] Reminder reminder)
        {

            if (ModelState.IsValid)
            {
                // Edit the reminder
                var editedReminder = _unitOfWork.Reminders.Get(reminder.ReminderId);
                editedReminder.TimeBeforeEvent = reminder.TimeBeforeEvent;
                editedReminder.EventId = reminder.EventId;
                editedReminder.ReminderTypeId = reminder.ReminderTypeId;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(reminder);

        }

        //
        // GET: /Reminder/Delete/5
        public ActionResult Delete(int id)
        {
            Reminder reminder = _unitOfWork.Reminders.Get(id);
            if (reminder == null)
            {
                return HttpNotFound();
            }
            return View(reminder);
        }

        //
        // POST: /Reminder/Delete/5
        [HttpPost, ActionName("Reminder")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reminder reminder = _unitOfWork.Reminders.Get(id);
            _unitOfWork.Reminders.Remove(reminder);
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
