using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class Newprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterIconUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "FootercontactText",
                table: "Settings");

            migrationBuilder.AddColumn<string>(
                name: "GmailIconUrl",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GmailText",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocIconUrl",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocText",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneIconUrl",
                table: "Settings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GmailIconUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "GmailText",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LocIconUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LocText",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "PhoneIconUrl",
                table: "Settings");

            migrationBuilder.AddColumn<string>(
                name: "FooterIconUrl",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FootercontactText",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
