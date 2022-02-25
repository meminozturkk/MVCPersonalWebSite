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

        public ActionResult EditCerficate()
        {

        }
    }
}