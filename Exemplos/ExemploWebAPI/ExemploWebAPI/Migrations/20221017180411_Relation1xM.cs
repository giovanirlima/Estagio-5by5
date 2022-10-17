using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploWebAPI.Migrations
{
    public partial class Relation1xM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPerson",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPerson",
                table: "Address");
        }
    }
}
