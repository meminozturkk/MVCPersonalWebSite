using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Repository;
using PersonalWebSite.Models.Entity;

namespace PersonalWebSite.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceReporsitory reporsitory = new ExperienceReporsitory();
        public ActionResult Index()
        {
            var experiences = reporsitory.List();
            return View(experiences);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience experience)
        {
            reporsitory.TAdd(experience);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            TblExperience experience = reporsitory.Find(x => x.Id == id);
            reporsitory.TDelete(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            TblExperience experience = reporsitory.Find(x => x.Id == id);
            return View(experience);
        }

        [HttpPost]
        public ActionResult GetExperience(TblExperience experiences)
        {
            TblExperience experience = reporsitory.Find(x => x.Id == experiences.Id);

            experience.Title = experiences.Title;
            experience.Subtitle = experiences.Subtitle;
            experience.Date = experiences.Date;
            experience.Explanation = experiences.Explanation;

            reporsitory.TUpdate(experience);


            return RedirectToAction("Index");
        }



    }
}