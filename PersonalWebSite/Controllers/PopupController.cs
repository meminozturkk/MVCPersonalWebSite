using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class PopupController : Controller
    {
        // GET: Popup
        public ActionResult Popup()
        {
            return RedirectToAction("Index");
        }
    }
}