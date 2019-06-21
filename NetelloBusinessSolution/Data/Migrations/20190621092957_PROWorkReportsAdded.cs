using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class PROWorkReportsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PROWorkReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    WorkStarted = table.Column<DateTime>(nullable: false),
                    WorkEnded = table.Column<DateTime>(nullable: false),
                    TimeWorked = table.Column<decimal>(nullable: false),
                    PaymentPerHour = table.Column<decimal>(nullable: true),
                    TotalPayment = table.Column<decimal>(nullable: true),
                    PurchaseOrderId = table.Column<int>(nullable: true),
                    WorkNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROWorkReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROWorkReport_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROWorkReport_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROWorkReport_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROWorkReport_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PROWorkReport_CompanyId",
                table: "PROWorkReport",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PROWorkReport_PersonId",
                table: "PROWorkReport",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROWorkReport_PersonId1",
                table: "PROWorkReport",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROWorkReport_PurchaseOrderId",
                table: "PROWorkReport",
                column: "PurchaseOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PROWorkReport");
        }
    }
}
