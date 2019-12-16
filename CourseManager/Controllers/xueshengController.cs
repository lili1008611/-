using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;

namespace CourseManager.Controllers
{
    public class xueshengController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        // GET: xuesheng
        public ActionResult Index()
        {
            return View(db.xuesheng.ToList());
        }

        // GET: xuesheng/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xuesheng xuesheng = db.xuesheng.Find(id);
            if (xuesheng == null)
            {
                return HttpNotFound();
            }
            return View(xuesheng);
        }

        // GET: xuesheng/Create
        public ActionResult Create()
        {
            var xueshengs = db.xuesheng.ToList();
            ViewBag.Xueshengs = xueshengs;
            return View();
        }

        // POST: xuesheng/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ClassId")] xuesheng xuesheng)
        {
            if (ModelState.IsValid)
            {
                db.xuesheng.Add(xuesheng);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xuesheng);
        }

        // GET: xuesheng/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xuesheng xuesheng = db.xuesheng.Find(id);
            if (xuesheng == null)
            {
                return HttpNotFound();
            }
            return View(xuesheng);
        }

        // POST: xuesheng/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ClassId")] xuesheng xuesheng)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xuesheng).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xuesheng);
        }

        // GET: xuesheng/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xuesheng xuesheng = db.xuesheng.Find(id);
            if (xuesheng == null)
            {
                return HttpNotFound();
            }
            return View(xuesheng);
        }

        // POST: xuesheng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            xuesheng xuesheng = db.xuesheng.Find(id);
            db.xuesheng.Remove(xuesheng);
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
