using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ITMO.ASP.NET.GradeBook.Sim.Models;
using System.Net;

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
        [HttpGet]
        public ActionResult EditGrade(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GradeBookModel gradeBookModel = GBook.gradeBookModels.Find(id);
            if (gradeBookModel == null)
            {
                return HttpNotFound();
            }
            return View(gradeBookModel);
        }
        [HttpPost]
        public ActionResult EditGrade(GradeBookModel gradeBook)
        {
            if (ModelState.IsValid)
            {                
                    GBook.Entry(gradeBook).State = EntityState.Modified;
                    GBook.SaveChanges();
                    return RedirectToAction("Index");
            }    
            return View(gradeBook);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(GradeBookModel gradeBook)
        {
            if (ModelState.IsValid)
            {
                GBook.gradeBookModels.Add(gradeBook);
                GBook.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gradeBook);
        }
    }
}