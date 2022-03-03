using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityExercize.Migrations
{
    public partial class DiscountRateAddedToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisCountRate",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisCountRate",
                table: "Products");
        }
    }
}
