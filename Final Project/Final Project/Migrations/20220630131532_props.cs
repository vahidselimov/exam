using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class props : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Copyrigth",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterIconUrl",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterName",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterTitle",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FootercontactText",
                table: "Settings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Copyrigth",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FooterIconUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FooterName",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FooterTitle",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FootercontactText",
                table: "Settings");
        }
    }
}
