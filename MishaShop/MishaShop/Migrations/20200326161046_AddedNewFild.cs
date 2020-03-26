using Microsoft.EntityFrameworkCore.Migrations;

namespace MishaShop.Migrations
{
    public partial class AddedNewFild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Goods",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Goods");
        }
    }
}
