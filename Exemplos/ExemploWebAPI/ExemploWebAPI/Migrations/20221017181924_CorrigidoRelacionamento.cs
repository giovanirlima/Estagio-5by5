using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploWebAPI.Migrations
{
    public partial class CorrigidoRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressPerson");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_PersonId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Address");

            migrationBuilder.CreateTable(
                name: "AddressPerson",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressPerson", x => new { x.AddressId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_AddressPerson_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressPerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressPerson_PersonId",
                table: "AddressPerson",
                column: "PersonId");
        }
    }
}
