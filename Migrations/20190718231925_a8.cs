using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "economyCode",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalCode",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ownerID",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ownerID",
                table: "Companies",
                column: "ownerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Owners_ownerID",
                table: "Companies",
                column: "ownerID",
                principalTable: "Owners",
                principalColumn: "ownerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Owners_ownerID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ownerID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "economyCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "nationalCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ownerID",
                table: "Companies");
        }
    }
}
