using Microsoft.EntityFrameworkCore.Migrations;

namespace KEK_Emlak.Repo.Migrations
{
    public partial class productupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SquareFeet",
                table: "Product",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "Image1",
                table: "Product",
                newName: "Location");

            migrationBuilder.AddColumn<string>(
                name: "DisplayImage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayImage",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Product",
                newName: "Image1");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Product",
                newName: "SquareFeet");
        }
    }
}
