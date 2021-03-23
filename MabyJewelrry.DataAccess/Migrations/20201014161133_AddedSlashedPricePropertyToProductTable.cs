using Microsoft.EntityFrameworkCore.Migrations;

namespace MabyJewelrry.DataAccess.Migrations
{
    public partial class AddedSlashedPricePropertyToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SlashedPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlashedPrice",
                table: "Products");
        }
    }
}
