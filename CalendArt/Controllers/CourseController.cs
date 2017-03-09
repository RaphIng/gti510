using System.Web.Mvc;
using CalendArt.Core.Domain;
using CalendArt.Infrastructure;

namespace CalendArt.Controllers
{
    public class CourseController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());

        // GET: Courses
        public ActionResult Index()
        {
            var courses = _unitOfWork.Courses.GetAll();
            return View(courses);
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            
            Course course = _unitOfWork.Courses.Get(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,Code,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Courses.Add(course);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            Course course = _unitOfWork.Courses.Get(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,Code,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                // Edit the course
                var editedCourse = _unitOfWork.Courses.Get(course.CourseId);
                editedCourse.Code = course.Code;
                editedCourse.Title = course.Title;
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            Course course = _unitOfWork.Courses.Get(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = _unitOfWork.Courses.Get(id);
            _unitOfWork.Courses.Remove(course);
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
