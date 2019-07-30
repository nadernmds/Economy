using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "education",
                table: "RealPersons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "skills",
                table: "RealPersons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personnelCount",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "education",
                table: "RealPersons");

            migrationBuilder.DropColumn(
                name: "skills",
                table: "RealPersons");

            migrationBuilder.DropColumn(
                name: "personnelCount",
                table: "Companies");
        }
    }
}
