namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cteate201912101058 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CourseBiao", "ClassName");
            DropColumn("dbo.CourseBiao", "CourseName");
            DropColumn("dbo.CourseBiao", "TeacherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseBiao", "TeacherName", c => c.Int(nullable: false));
            AddColumn("dbo.CourseBiao", "CourseName", c => c.Int(nullable: false));
            AddColumn("dbo.CourseBiao", "ClassName", c => c.Int(nullable: false));
        }
    }
}
