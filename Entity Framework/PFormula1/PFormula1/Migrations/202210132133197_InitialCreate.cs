namespace PFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false),
                        Ano = c.Int(nullable: false),
                        Unidade = c.Int(nullable: false),
                        Id_Equipe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Id_Equipe, cascadeDelete: true)
                .Index(t => t.Id_Equipe);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Pilots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Id_Equipe", "dbo.Teams");
            DropIndex("dbo.Cars", new[] { "Id_Equipe" });
            DropTable("dbo.Pilots");
            DropTable("dbo.Teams");
            DropTable("dbo.Cars");
        }
    }
}
