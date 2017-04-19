namespace TIYSportsPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AwayHomeGamesSportsAdded1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AwayTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AwayTeamName = c.String(),
                        TeamDescription = c.String(),
                        NumOfPlayers = c.Int(nullable: false),
                        TeamImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomeTeamId = c.Int(nullable: false),
                        AwayTeamId = c.Int(nullable: false),
                        GameScore = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HomeTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomeTeamName = c.String(),
                        TeamDescription = c.String(),
                        NumOfPlayers = c.Int(nullable: false),
                        TeamImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportName = c.Int(nullable: false),
                        Url = c.String(),
                        SportImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sports");
            DropTable("dbo.HomeTeams");
            DropTable("dbo.Games");
            DropTable("dbo.AwayTeams");
        }
    }
}
