using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebSite.Models.Entity;
using System.Web.Security;

namespace PersonalWebSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin admin)
        {
            DbCvEntities entities = new DbCvEntities();
            var userInfo = entities.TblAdmins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.Username, false);
                Session["Username"] = userInfo.Username.ToString();

                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");

         }

       
    }


}