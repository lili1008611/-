namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create201912100945 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseBiao", "ClassName", c => c.Int(nullable: false));
            AddColumn("dbo.CourseBiao", "CourseName", c => c.Int(nullable: false));
            AddColumn("dbo.CourseBiao", "TeacherName", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseBiao", "TeacherName");
            DropColumn("dbo.CourseBiao", "CourseName");
            DropColumn("dbo.CourseBiao", "ClassName");
        }
    }
}
