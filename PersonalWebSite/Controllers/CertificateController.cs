using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Models.Entity;
using PersonalWebSite.Repository;
using PersonalWebSite.Controllers;

namespace PersonalWebSite.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate
        GenericRepository<TblCertificate> reporsitory = new GenericRepository<TblCertificate>();
        public ActionResult Index()
        {
            var certificate = reporsitory.List();
            return View(certificate);
        }
        [HttpGet]
        public ActionResult EditCerficate(int id)
        {
            TblCertificate certificate = reporsitory.Find(x => x.Id == id);
            return View(certificate);
        }

        [HttpPost]

        public ActionResult EditCerficate(TblCertificate c)
        {
            TblCertificate certificate = reporsitory.Find(x => x.Id == c.Id);

            certificate.Explanation = c.Explanation;

            reporsitory.TUpdate(certificate);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteCertificate(int id)
        {
            TblCertificate certificate = reporsitory.Find(x => x.Id == id);
            reporsitory.TDelete(certificate);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCertificate(TblCertificate certificate)
        {
            reporsitory.TAdd(certificate);

            return RedirectToAction("Index");
        }


    }
}