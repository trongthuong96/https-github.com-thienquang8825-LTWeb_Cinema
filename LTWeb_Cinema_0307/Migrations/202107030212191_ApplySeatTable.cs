namespace LTWeb_Cinema_0307.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplySeatTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeatNo = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Reservations", "SeatId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "SeatId");
            AddForeignKey("dbo.Reservations", "SeatId", "dbo.Seats", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "SeatId", "dbo.Seats");
            DropIndex("dbo.Reservations", new[] { "SeatId" });
            DropColumn("dbo.Reservations", "SeatId");
            DropTable("dbo.Seats");
        }
    }
}
