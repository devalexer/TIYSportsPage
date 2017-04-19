namespace TIYSportsPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SportInfoAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sports", "SportName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sports", "SportName", c => c.Int(nullable: false));
        }
    }
}
