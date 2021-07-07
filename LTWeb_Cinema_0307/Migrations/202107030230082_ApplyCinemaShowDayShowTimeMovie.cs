namespace LTWeb_Cinema_0307.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyCinemaShowDayShowTimeMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShowDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShowTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Shows", "CinemaId", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "MovieId", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "ShowDayId", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "ShowTimeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shows", "CinemaId");
            CreateIndex("dbo.Shows", "MovieId");
            CreateIndex("dbo.Shows", "ShowDayId");
            CreateIndex("dbo.Shows", "ShowTimeId");
            AddForeignKey("dbo.Shows", "CinemaId", "dbo.Cinemas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Shows", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Shows", "ShowDayId", "dbo.ShowDays", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Shows", "ShowTimeId", "dbo.ShowTimes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "ShowTimeId", "dbo.ShowTimes");
            DropForeignKey("dbo.Shows", "ShowDayId", "dbo.ShowDays");
            DropForeignKey("dbo.Shows", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Shows", "CinemaId", "dbo.Cinemas");
            DropIndex("dbo.Shows", new[] { "ShowTimeId" });
            DropIndex("dbo.Shows", new[] { "ShowDayId" });
            DropIndex("dbo.Shows", new[] { "MovieId" });
            DropIndex("dbo.Shows", new[] { "CinemaId" });
            DropColumn("dbo.Shows", "ShowTimeId");
            DropColumn("dbo.Shows", "ShowDayId");
            DropColumn("dbo.Shows", "MovieId");
            DropColumn("dbo.Shows", "CinemaId");
            DropTable("dbo.ShowTimes");
            DropTable("dbo.ShowDays");
            DropTable("dbo.Movies");
            DropTable("dbo.Cinemas");
        }
    }
}
