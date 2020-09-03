using ActionSelectorsMVC5_Demo.Data;
using ActionSelectorsMVC5_Demo.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ActionSelectorsMVC5_Demo.Controllers
{
    public class CategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        [AcceptVerbs(HttpVerbs.Post), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
