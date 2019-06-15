using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class Restart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Document",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_CourseId",
                table: "Person",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_CourseId",
                table: "Document",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Course_CourseId",
                table: "Document",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Course_CourseId",
                table: "Person",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Course_CourseId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Course_CourseId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Person_CourseId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Document_CourseId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Document");
        }
    }
}
