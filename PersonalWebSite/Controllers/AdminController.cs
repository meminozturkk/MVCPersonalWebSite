using PersonalWebSite.Models.Entity;
using PersonalWebSite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repository = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var adminList = repository.List();
            return View(adminList);
        }
        [HttpPost]
		public ActionResult Index(TblAdmin admin)
		{
            TblAdmin tblAdmin = repository.Find(x => x.Id == 1);
            tblAdmin.Username= admin.Username;
            tblAdmin.Password= admin.Password;

			repository.TUpdate(tblAdmin);

			return RedirectToAction("Index");
		}
	}
}