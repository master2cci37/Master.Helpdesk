namespace Master.Metier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Historiques",
                c => new
                    {
                        HistoriqueID = c.Int(nullable: false, identity: true),
                        TicketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HistoriqueID)
                .ForeignKey("dbo.Tickets", t => t.TicketID, cascadeDelete: true)
                .Index(t => t.TicketID);
            
            CreateTable(
                "dbo.Priorites",
                c => new
                    {
                        PrioriteID = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.PrioriteID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        EstActif = c.Boolean(nullable: false),
                        PrioriteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Priorites", t => t.PrioriteID, cascadeDelete: true)
                .Index(t => t.PrioriteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "PrioriteID", "dbo.Priorites");
            DropForeignKey("dbo.Historiques", "TicketID", "dbo.Tickets");
            DropIndex("dbo.Tickets", new[] { "PrioriteID" });
            DropIndex("dbo.Historiques", new[] { "TicketID" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Priorites");
            DropTable("dbo.Historiques");
        }
    }
}
