using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.BLLs.Class
{
    public interface IClassRepository
    {
        List<CourseBiaoDetail> GetClassCourse(int id);
    }
}
