using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_userID",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_userID",
                table: "Owners");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Users",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Owners",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Owners_userID",
                table: "Owners",
                newName: "IX_Owners_userId");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "CompanyUser",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_userID",
                table: "CompanyUser",
                newName: "IX_CompanyUser_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_userId",
                table: "CompanyUser",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_userId",
                table: "Owners",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_userId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_userId",
                table: "Owners");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Users",
                newName: "userID");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Owners",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_Owners_userId",
                table: "Owners",
                newName: "IX_Owners_userID");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "CompanyUser",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_userId",
                table: "CompanyUser",
                newName: "IX_CompanyUser_userID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_userID",
                table: "CompanyUser",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_userID",
                table: "Owners",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
