using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.BLLs.Class
{
    public class ClassRepository : IClassRepository
    {
        protected CourseManagerEntities db = new CourseManagerEntities();
        public List<CourseBiaoDetail> GetClassCourse(int id)
        {
            var query =
                from cm in db.CourseBiao
                join c in db.Class
                   on cm.ClassId equals c.Id
                join t in db.Teacher
                   on cm.TeacherId equals t.Id
                join k in db.kecheng
                    on cm.CourseId equals k.Id
                where cm.ClassId == id
                select new CourseBiaoDetail
                {
                    ClassName = c.Name,
                    TeacherName=t.Name,
                    CourseName=k.CourdeName
                };
            return query.ToList();
        }
    }
}