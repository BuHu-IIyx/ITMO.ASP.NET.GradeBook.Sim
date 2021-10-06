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
            return View(GBook.gradeBookModels.ToList());
        }
        public ActionResult Best5Students()
        {
            ViewBag.MidGrade = CalculateMid.Midle(GBook, false);
            return View();
        }
        public ActionResult Worst5Students()
        {
            ViewBag.MidGrade = CalculateMid.Midle(GBook, true);
            return View();
        }
    }
}