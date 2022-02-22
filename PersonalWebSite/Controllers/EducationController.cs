using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Repository;
using PersonalWebSite.Models.Entity;


namespace PersonalWebSite.Controllers
{

    public class EducationController : Controller
    {
        // GET: Education
        GenericRepository<TblEducation> repository = new GenericRepository<TblEducation>();
        public ActionResult Index()
        {
            var education = repository.List();
            return View(education);
        }
        public ActionResult DeleteEducation(int id)
        {
            var education = repository.Find(x => x.Id == id);
            repository.TDelete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(TblEducation education)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repository.TAdd(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetEducation(int id)
        {
            TblEducation education = repository.Find(x => x.Id == id);
            return View(education);
        }
        
        [HttpPost]
        public ActionResult GetEducation(TblEducation e)
        {
            var education = repository.Find(x => x.Id == e.Id);
            education.Title = e.Title;
            education.Subtitle1 = e.Subtitle1;
            education.Subtitle2 = e.Subtitle2;
            education.GNO = e.GNO;
            education.Date = e.Date;

            repository.TUpdate(education);

            return RedirectToAction("Index");
        }
 
    }
}