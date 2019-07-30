using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Owners_ownerID",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ownerID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "economyCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ownerID",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "nationalCode",
                table: "Users",
                newName: "post");

            migrationBuilder.AddColumn<int>(
                name: "realPersonID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "realPersonID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "post",
                table: "Users",
                newName: "nationalCode");

            migrationBuilder.AddColumn<string>(
                name: "economyCode",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ownerID",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    ownerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    mobile = table.Column<string>(nullable: true),
                    post = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.ownerID);
                    table.ForeignKey(
                        name: "FK_Owners_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ownerID",
                table: "Companies",
                column: "ownerID");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_userId",
                table: "Owners",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Owners_ownerID",
                table: "Companies",
                column: "ownerID",
                principalTable: "Owners",
                principalColumn: "ownerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
