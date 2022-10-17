﻿using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploWebAPI.Migrations
{
    public partial class AddPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Person");
        }
    }
}
