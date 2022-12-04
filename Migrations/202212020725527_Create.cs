namespace FootBallMatchs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootBalls",
                c => new
                    {
                        MatchID = c.Int(nullable: false),
                        TeamName1 = c.String(nullable: false, maxLength: 255),
                        TeamName2 = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        WinningTeam = c.String(nullable: false),
                        Points = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FootBalls");
        }
    }
}
