using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Post",
                table: "Owners",
                newName: "post");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "Owners",
                newName: "ownerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "post",
                table: "Owners",
                newName: "Post");

            migrationBuilder.RenameColumn(
                name: "ownerID",
                table: "Owners",
                newName: "OwnerID");
        }
    }
}
