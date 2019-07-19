using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "emount",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "emount",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
