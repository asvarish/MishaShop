using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MishaShop.Migrations
{
    public partial class addedFileUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Goods",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Goods");
        }
    }
}
