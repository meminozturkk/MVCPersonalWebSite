using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Models.Entity;
using PersonalWebSite.Repository;

namespace PersonalWebSite.Controllers
{
    public class ContactController : Controller
    {
        GenericRepository<TblContact> repository = new GenericRepository<TblContact>();
        // GET: Contact
        public ActionResult Index()
        {
            var contact = repository.List();
            return View(contact);
        }

        public ActionResult DeleteContact(int id)
        {
            var contact = repository.Find(x => x.Id == id);
            repository.TDelete(contact);
            return RedirectToAction("Index");
        }
    }
}