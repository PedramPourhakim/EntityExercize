using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityExercize.Migrations
{
    public partial class FluentApiAddedToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Mahsoolat");

            migrationBuilder.RenameColumn(
                name: "IsRemoved",
                table: "Mahsoolat",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "IsInStock",
                table: "Mahsoolat",
                newName: "Available In Stock");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mahsoolat",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahsoolat",
                table: "Mahsoolat",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahsoolat",
                table: "Mahsoolat");

            migrationBuilder.RenameTable(
                name: "Mahsoolat",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Products",
                newName: "IsRemoved");

            migrationBuilder.RenameColumn(
                name: "Available In Stock",
                table: "Products",
                newName: "IsInStock");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
