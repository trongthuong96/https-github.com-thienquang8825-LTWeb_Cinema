namespace LTWeb_Cinema_0307.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyASPNETUSER_Reservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropTable("dbo.Reservations");
        }
    }
}
