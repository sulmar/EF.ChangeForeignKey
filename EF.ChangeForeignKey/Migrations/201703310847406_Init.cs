namespace EF.ChangeForeignKey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientAddresses",
                c => new
                    {
                        ClientAddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        Client_ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientAddressId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete:true, name:"FK_Client_Address")
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAddresses", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.ClientAddresses", new[] { "Client_ClientId" });
            DropTable("dbo.Clients");
            DropTable("dbo.ClientAddresses");
        }
    }
}
