using System.Web.Mvc;
using CalendArt.Core.Domain;
using CalendArt.Infrastructure;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CalendArt.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork _unitOfWork = new UnitOfWork(new CalendArtContext());

        public ActionResult Index()
        {
            var _courses = _unitOfWork.Courses.GetAll().ToList();
            var _events = _unitOfWork.Events.GetAll();

            List<Course> courses = new List<Course>();
            courses.Add(new Course() { Code = "MAT415", CourseId = 1, Dates = new List<DateTime?>() {DateTime.Today.ToUniversalTime(), new DateTime(2017, 3, 18, 23, 00, 00).ToUniversalTime()}, Title = "Mathématique" });
            courses.Add(new Course() { Code = "GTI210", CourseId = 2, Dates = new List<DateTime?>() { new DateTime(2017, 3, 26,23,00,00).ToUniversalTime()}, Title = "Programmation" });

         

            ViewBag.Courses = courses;
            ViewBag.Events = _events;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}