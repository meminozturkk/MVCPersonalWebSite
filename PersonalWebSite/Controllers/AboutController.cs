using PersonalWebSite.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Repository;


namespace PersonalWebSite.Controllers
{
   // [Authorize]
    public class AboutController : Controller
    {
        DbCvEntities dbCv = new DbCvEntities();
        GenericRepository<TblAbout> repository = new GenericRepository<TblAbout>();
        // GET: Interest
        
        public ActionResult Index()
        {
            var interest = repository.List();
            return View(interest);
        }


        [HttpPost]
        public ActionResult Index(TblAbout a)
        {

            TblAbout about = repository.Find(x => x.Id == 1);
            about.Explanation = a.Explanation;
            about.Mail = a.Mail;
            about.Name = a.Name;
            about.Surname = a.Surname;
            about.Telephone = a.Telephone;
            about.Image = a.Image;

            repository.TUpdate(about);

            return RedirectToAction("Index");
        }
    }
}