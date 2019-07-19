using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Assets",
                newName: "emount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "emount",
                table: "Assets",
                newName: "description");
        }
    }
}
