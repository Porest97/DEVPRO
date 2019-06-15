using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class SupportCases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportCase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeReported = table.Column<DateTime>(nullable: true),
                    TimeStarted = table.Column<DateTime>(nullable: true),
                    TimeFEScheduled = table.Column<DateTime>(nullable: true),
                    TimeSolved = table.Column<DateTime>(nullable: true),
                    TotalTimeOnSite = table.Column<decimal>(nullable: true),
                    BusinessCentreId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    Descrition = table.Column<string>(nullable: true),
                    PurchaseOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportCase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportCase_BusinessCentre_BusinessCentreId",
                        column: x => x.BusinessCentreId,
                        principalTable: "BusinessCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportCase_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportCase_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportCase_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupportCase_BusinessCentreId",
                table: "SupportCase",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCase_PersonId",
                table: "SupportCase",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCase_PersonId1",
                table: "SupportCase",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCase_PurchaseOrderId",
                table: "SupportCase",
                column: "PurchaseOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportCase");
        }
    }
}
