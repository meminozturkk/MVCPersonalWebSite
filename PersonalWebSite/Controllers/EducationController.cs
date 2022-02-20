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

        [HttpPost]
        public ActionResult NewEducation(TblEducation education)
        {
            repository.TAdd(education);
            return RedirectToAction("Index");
        }


    }
}