using PersonalWebSite.Models.Entity;
using PersonalWebSite.Repository;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        GenericRepository<TblSocialMedia> repository = new GenericRepository<TblSocialMedia>();
        public ActionResult Index()
        {
            var media = repository.List();
            return View(media);
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            TblSocialMedia media = repository.Find(x => x.ID == id);
            repository.TDelete(media);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSocialMedia(int id)
        {
            TblSocialMedia media = repository.Find(x => x.ID == id);
            return View(media);
        }
        [HttpPost]
        public ActionResult EditSocialMedia(TblSocialMedia m)
        {
            var media = repository.Find(x => x.ID == m.ID);
            media.Name = m.Name;
            media.Link = m.Link;
            media.Icon = m.Icon;
            repository.TUpdate(media);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia socialMedia)
        {
            repository.TAdd(socialMedia);
            return RedirectToAction("Index");
        }


    }
}