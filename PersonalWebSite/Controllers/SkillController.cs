using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Controllers;
using PersonalWebSite.Repository;
using PersonalWebSite.Models.Entity;

namespace PersonalWebSite.Controllers
{
    public class SkillController : Controller
    {

        // GET: Skill
        GenericRepository<TblSkill> repository = new GenericRepository<TblSkill>();
        public ActionResult Index()
        {
            var skills = repository.List();
            return View(skills);
        }

        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSkill(TblSkill skills)
        {
            repository.TAdd(skills);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var skill = repository.Find(x => x.Id == id);
            repository.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = repository.Find(x => x.Id == id);
            return View(skill);
        }

        [HttpPost]
        public ActionResult EditSkill(TblSkill skills)
        {
            var skill = repository.Find(x => x.Id == skills.Id);
            skill.Skill = skills.Skill;
            skill.Rate = skills.Rate;
            repository.TUpdate(skill);
            return RedirectToAction("Index");
        }

    }



}