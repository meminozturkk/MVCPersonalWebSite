using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Models.Entity;
using PersonalWebSite.Repository;
    
namespace PersonalWebSite.Controllers
{
    public class InterestController : Controller
    {
        GenericRepository<TblInterest> repository = new GenericRepository<TblInterest>();
        // GET: Interest
        [HttpGet]
        public ActionResult Index()
        {
            var interest = repository.List();
            return View(interest);
        }

  
        [HttpPost]
        public ActionResult Index(TblInterest i)
        {

            TblInterest interest = repository.Find(x => x.Id == 1);
            interest.Explanation1 = i.Explanation1;
            interest.Explanation2 = i.Explanation2;

            repository.TUpdate(interest);

            return RedirectToAction("Index");
        }
    }
}