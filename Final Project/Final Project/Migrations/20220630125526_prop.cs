using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p1",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p2",
                table: "Settings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "p1",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "p2",
                table: "Settings");
        }
    }
}
