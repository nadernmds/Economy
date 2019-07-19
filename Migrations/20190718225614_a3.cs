using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyID",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_companyID",
                table: "Projects",
                column: "companyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Companies_companyID",
                table: "Projects",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_companyID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_companyID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "companyID",
                table: "Projects");
        }
    }
}
