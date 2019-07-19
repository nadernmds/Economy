using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Economy.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "astanInvestment",
                table: "Projects",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "capacity",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "doLenght",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ownerInvestment",
                table: "Projects",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "projectTypeID",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    projectTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    typeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.projectTypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_projectTypeID",
                table: "Projects",
                column: "projectTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectType_projectTypeID",
                table: "Projects",
                column: "projectTypeID",
                principalTable: "ProjectType",
                principalColumn: "projectTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectType_projectTypeID",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectType");

            migrationBuilder.DropIndex(
                name: "IX_Projects_projectTypeID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "astanInvestment",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "capacity",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "doLenght",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ownerInvestment",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "projectTypeID",
                table: "Projects");
        }
    }
}
