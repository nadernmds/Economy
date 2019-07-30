using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "realPersonID",
                table: "Assets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "emount",
                table: "Assets",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "Assets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "assetTypeID",
                table: "Assets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetType_assetTypeID",
                table: "Assets",
                column: "assetTypeID",
                principalTable: "AssetType",
                principalColumn: "assetTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Companies_companyID",
                table: "Assets",
                column: "companyID",
                principalTable: "Companies",
                principalColumn: "companyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_RealPersons_realPersonID",
                table: "Assets",
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

            migrationBuilder.AlterColumn<int>(
                name: "realPersonID",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "emount",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "companyID",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "assetTypeID",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
        }
    }
}
