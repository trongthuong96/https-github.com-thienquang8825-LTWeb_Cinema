namespace LTWeb_Cinema_0307.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyShowTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Reservations", "ShowId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "ShowId");
            AddForeignKey("dbo.Reservations", "ShowId", "dbo.Shows", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ShowId", "dbo.Shows");
            DropIndex("dbo.Reservations", new[] { "ShowId" });
            DropColumn("dbo.Reservations", "ShowId");
            DropTable("dbo.Shows");
        }
    }
}
