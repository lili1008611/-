using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly CourseManager.Models.CourseManagerEntities _context;
        public SideBarCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {
                    Name="班级管理",
                    Controller="Class",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="老师管理",
                    Controller="Teacher",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="学生管理",
                    Controller="xuesheng",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="课程科目管理",
                    Controller="kecheng",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="课程安排",
                    Controller="CourseBiao",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="顶部导航栏管理",
                    Controller="ActionLink",
                    Ation="Index"
                },
                new SideBars
                {
                    Name="侧边栏管理",
                    Controller="SideBar",
                    Ation="Index"
                },
            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}