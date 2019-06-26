using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class SalariesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PeriodStartDate = table.Column<DateTime>(nullable: false),
                    PeriodEndDate = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: true),
                    ArticleId = table.Column<int>(nullable: true),
                    Hours = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    PayedOut = table.Column<bool>(nullable: false),
                    AmountPayedOut = table.Column<decimal>(nullable: false),
                    DatePayedOut = table.Column<DateTime>(nullable: true),
                    AmountDueToPayOut = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salary_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salary_ArticleId",
                table: "Salary",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_PersonId",
                table: "Salary",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salary");
        }
    }
}
