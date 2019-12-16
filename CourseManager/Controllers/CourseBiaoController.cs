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
    public class CourseBiaoController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        // GET: CourseBiao
        public ActionResult Index()
        {
            return View(db.CourseBiao.ToList());
        }

        // GET: CourseBiao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseBiao courseBiao = db.CourseBiao.Find(id);
            if (courseBiao == null)
            {
                return HttpNotFound();
            }
            return View(courseBiao);
        }

        // GET: CourseBiao/Create
        public ActionResult Create()
        {
            var classe = db.Class.ToList();
            ViewBag.Class = classe;
            var teachers = db.Teacher.ToList();
            ViewBag.Teacher = teachers;
            var kechengs = db.kecheng.ToList();
            ViewBag.Kechengs = kechengs;

            return View();
        }

        // POST: CourseBiao/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClassId,CourseId,TeacherId")] CourseBiao courseBiao)
        {
            if (ModelState.IsValid)
            {
                db.CourseBiao.Add(courseBiao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseBiao);
        }

        // GET: CourseBiao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseBiao courseBiao = db.CourseBiao.Find(id);
            if (courseBiao == null)
            {
                return HttpNotFound();
            }
            return View(courseBiao);
        }

        // POST: CourseBiao/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassId,CourseId,TeacherId")] CourseBiao courseBiao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseBiao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseBiao);
        }

        // GET: CourseBiao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseBiao courseBiao = db.CourseBiao.Find(id);
            if (courseBiao == null)
            {
                return HttpNotFound();
            }
            return View(courseBiao);
        }

        // POST: CourseBiao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseBiao courseBiao = db.CourseBiao.Find(id);
            db.CourseBiao.Remove(courseBiao);
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
