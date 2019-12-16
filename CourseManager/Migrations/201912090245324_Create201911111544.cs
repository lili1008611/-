namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create201911111544 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.xuesheng", "ClassId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.xuesheng", "ClassId", c => c.Int(nullable: false));
        }
    }
}
