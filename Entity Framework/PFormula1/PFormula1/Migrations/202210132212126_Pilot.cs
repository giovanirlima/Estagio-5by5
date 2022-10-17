namespace PFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pilot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pilots", "nome", c => c.String());
            DropColumn("dbo.Pilots", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pilots", "Name", c => c.String());
            DropColumn("dbo.Pilots", "nome");
        }
    }
}
