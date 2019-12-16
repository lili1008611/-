namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create201912100918 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Class", "TeacherId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Class", "TeacherId", c => c.Int());
        }
    }
}
