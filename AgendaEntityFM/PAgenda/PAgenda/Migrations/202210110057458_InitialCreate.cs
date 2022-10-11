namespace PAgenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        TelephoneBookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.TelephoneBooks", t => t.TelephoneBookId, cascadeDelete: true)
                .Index(t => t.TelephoneBookId);
            
            CreateTable(
                "dbo.TelephoneBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cel = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "TelephoneBookId", "dbo.TelephoneBooks");
            DropIndex("dbo.People", new[] { "TelephoneBookId" });
            DropTable("dbo.TelephoneBooks");
            DropTable("dbo.People");
        }
    }
}
