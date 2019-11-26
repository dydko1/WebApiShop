using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiShop.Migrations
{
    public partial class ShopInitial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desription",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desription",
                table: "Product",
                nullable: true);
        }
    }
}
