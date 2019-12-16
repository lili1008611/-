using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class CourseBiao
    {
        public string TeacherName
        {
            get
            {
                if (TeacherId == 0)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var teacher = db.Teacher.Where(t => t.Id == TeacherId).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
        public string CourseName
        {
            get
            {
                if (CourseId == 0)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var course = db.kecheng.Where(t => t.Id == CourseId).FirstOrDefault();
                if (course == null)
                {
                    return "";
                }
                return course.CourdeName;
            }
        }
        public string ClassName
        {
            get
            {
                if (ClassId == 0)
                {
                    return "";
                }
                CourseManagerEntities db = new CourseManagerEntities();
                var classes = db.Class.Where(t => t.Id == ClassId).FirstOrDefault();
                if (classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }
    }
}