using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalendArt.Infrastructure;
using System.Data.SqlClient;

namespace CalendArt.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            /*using (SqlConnection conn = new SqlConnection(""))
            {
                conn.Open(); // throws if invalid
            }*/
            using (var unitOfWork = new UnitOfWork(new CalendArtContext()))
            {
                // Example1
                var cours = unitOfWork.Cours.Get(1);

                unitOfWork.Cours.Remove(cours);
                // Example2
                //var courses = unitOfWork.Cours.GetCoursesWithAuthors(1, 4);

                // Example3
                //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                //unitOfWork.Courses.RemoveRange(author.Courses);
                //unitOfWork.Authors.Remove(author);
                unitOfWork.Complete();
            }


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