using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Companies_companyID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_companyID",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_userId",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "post",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "realPersonID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "mobile",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "CompanyUser",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_userId",
                table: "CompanyUser",
                newName: "IX_CompanyUser_userID");

            migrationBuilder.AddColumn<int>(
                name: "realPersonID",
                table: "Projects",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "CompanyUser",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "CompanyUser",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalCode",
                table: "Companies",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "assetTypeID",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "realPersonID",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    assetTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    assetType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.assetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RealPersons",
                columns: table => new
                {
                    realPersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    post = table.Column<string>(nullable: true),
                    nationalCode = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    ActivityTypeactivtyTypeID = table.Column<int>(nullable: true),
                    companyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealPersons", x => x.realPersonID);
                    table.ForeignKey(
                        name: "FK_RealPersons_ActivityTypes_ActivityTypeactivtyTypeID",
                        column: x => x.ActivityTypeactivtyTypeID,
                        principalTable: "ActivityTypes",
                        principalColumn: "activtyTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RealPersons_Companies_companyID",
                        column: x => x.companyID,
                        principalTable: "Companies",
                        principalColumn: "companyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_realPersonID",
                table: "Projects",
                column: "realPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_assetTypeID",
                table: "Assets",
                column: "assetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_realPersonID",
                table: "Assets",
                column: "realPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_RealPersons_ActivityTypeactivtyTypeID",
                table: "RealPersons",
                column: "ActivityTypeactivtyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RealPersons_companyID",
                table: "RealPersons",
                column: "companyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetType_assetTypeID",
                table: "Assets",
                column: "assetTypeID",
                principalTable: "AssetType",
                principalColumn: "assetTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Companies_companyID",
                table: "Assets",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_RealPersons_realPersonID",
                table: "Assets",
                column: "realPersonID",
                principalTable: "RealPersons",
                principalColumn: "realPersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_companyID",
                table: "CompanyUser",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_userID",
                table: "CompanyUser",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_RealPersons_realPersonID",
                table: "Projects",
                column: "realPersonID",
                principalTable: "RealPersons",
                principalColumn: "realPersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetType_assetTypeID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Companies_companyID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_RealPersons_realPersonID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_companyID",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_userID",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_RealPersons_realPersonID",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "RealPersons");

            migrationBuilder.DropIndex(
                name: "IX_Projects_realPersonID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Assets_assetTypeID",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_realPersonID",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "realPersonID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "nationalCode",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "assetTypeID",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "realPersonID",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "CompanyUser",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_userID",
                table: "CompanyUser",
                newName: "IX_CompanyUser_userId");

            migrationBuilder.AddColumn<string>(
                name: "post",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "realPersonID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobile",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "CompanyUser",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "CompanyUser",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "Assets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Companies_companyID",
                table: "Assets",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_companyID",
                table: "CompanyUser",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_userId",
                table: "CompanyUser",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
