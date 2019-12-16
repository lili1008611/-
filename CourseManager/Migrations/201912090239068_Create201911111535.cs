namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create201911111535 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.kecheng", "CourdeName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.kecheng", "CourdeName", c => c.Int(nullable: false));
        }
    }
}
