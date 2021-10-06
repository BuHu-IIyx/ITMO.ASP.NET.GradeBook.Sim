using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET.GradeBook.Sim.Models;

namespace ITMO.ASP.NET.GradeBook.Sim.Controllers
{
    public class HomeController : Controller
    {
        //Создание экземпляра контекста
        GradeBookContext GBook = new GradeBookContext();
        public ActionResult Index()
        {
            var allGrade = GBook.gradeBookModels;
            ViewBag.GradeBook = allGrade;
            
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