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

    }



}