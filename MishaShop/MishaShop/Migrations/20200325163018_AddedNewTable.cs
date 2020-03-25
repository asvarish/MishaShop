using Microsoft.EntityFrameworkCore.Migrations;

namespace MishaShop.Migrations
{
    public partial class AddedNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    FileId = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 600, nullable: false),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.FileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
