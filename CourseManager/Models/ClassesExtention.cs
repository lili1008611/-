using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Class
    {
        public string TeacherName
        {
            get
            {
                if (TeacherId==0)
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
    }
}