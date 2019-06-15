using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class PurchseOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PurchaseOrderNumber = table.Column<string>(nullable: true),
                    BusinessCentreId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    Descrition = table.Column<string>(nullable: true),
                    TimeOnSite = table.Column<decimal>(nullable: false),
                    KostPerHour = table.Column<decimal>(nullable: false),
                    TotalKost = table.Column<decimal>(nullable: false),
                    JobbScheduled = table.Column<DateTime>(nullable: true),
                    JobbStarted = table.Column<DateTime>(nullable: true),
                    JobbEnded = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_BusinessCentre_BusinessCentreId",
                        column: x => x.BusinessCentreId,
                        principalTable: "BusinessCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupportTicket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStampCreated = table.Column<DateTime>(nullable: false),
                    TimeStampResolved = table.Column<DateTime>(nullable: true),
                    TimeStampClosed = table.Column<DateTime>(nullable: true),
                    BusinessCentreId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    FaultDescription = table.Column<string>(nullable: true),
                    FaultReport = table.Column<string>(nullable: true),
                    TicketLog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportTicket_BusinessCentre_BusinessCentreId",
                        column: x => x.BusinessCentreId,
                        principalTable: "BusinessCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportTicket_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportTicket_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_BusinessCentreId",
                table: "PurchaseOrder",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PersonId",
                table: "PurchaseOrder",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PersonId1",
                table: "PurchaseOrder",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicket_BusinessCentreId",
                table: "SupportTicket",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicket_PersonId",
                table: "SupportTicket",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicket_PersonId1",
                table: "SupportTicket",
                column: "PersonId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "SupportTicket");
        }
    }
}
