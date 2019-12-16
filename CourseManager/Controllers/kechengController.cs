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
    public class kechengController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        // GET: kecheng
        public ActionResult Index()
        {
            return View(db.kecheng.ToList());
        }

        // GET: kecheng/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kecheng kecheng = db.kecheng.Find(id);
            if (kecheng == null)
            {
                return HttpNotFound();
            }
            return View(kecheng);
        }

        // GET: kecheng/Create
        public ActionResult Create()
        {
            var kechengs = db.kecheng.ToList();
            ViewBag.kecheng = kechengs;
 
            return View();
        }

        // POST: kecheng/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CourdeName")] kecheng kecheng)
        {
            if (ModelState.IsValid)
            {
                db.kecheng.Add(kecheng);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kecheng);
        }

        // GET: kecheng/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kecheng kecheng = db.kecheng.Find(id);
            if (kecheng == null)
            {
                return HttpNotFound();
            }
            return View(kecheng);
        }

        // POST: kecheng/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourdeName")] kecheng kecheng)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kecheng).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kecheng);
        }

        // GET: kecheng/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kecheng kecheng = db.kecheng.Find(id);
            if (kecheng == null)
            {
                return HttpNotFound();
            }
            return View(kecheng);
        }

        // POST: kecheng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kecheng kecheng = db.kecheng.Find(id);
            db.kecheng.Remove(kecheng);
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
