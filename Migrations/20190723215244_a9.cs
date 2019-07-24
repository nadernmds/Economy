using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobile",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startDate",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "mobile",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "Companies");
        }
    }
}
