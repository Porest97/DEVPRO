using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROSupport.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Ssn = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    CompanyRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessCentre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    CentreNumber = table.Column<int>(nullable: true),
                    CentreName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    NumberOfFloors = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    CentreNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessCentre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessCentre_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessCentre_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessCentre_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DworkinWiFiSurveyResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessCentreId = table.Column<int>(nullable: true),
                    ReportDate = table.Column<DateTime>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    TimeOnSite = table.Column<decimal>(nullable: true),
                    AccessPoints = table.Column<int>(nullable: true),
                    AccessPointsBrandModel = table.Column<string>(nullable: true),
                    A = table.Column<string>(nullable: true),
                    B = table.Column<string>(nullable: true),
                    C = table.Column<string>(nullable: true),
                    D = table.Column<string>(nullable: true),
                    E = table.Column<string>(nullable: true),
                    F = table.Column<string>(nullable: true),
                    G = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DworkinWiFiSurveyResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DworkinWiFiSurveyResult_BusinessCentre_BusinessCentreId",
                        column: x => x.BusinessCentreId,
                        principalTable: "BusinessCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DworkinWiFiSurveyResult_Person_PersonId",
                        column: x => x.PersonId,
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

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    BusinessCentreId = table.Column<int>(nullable: true),
                    SupportTicketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_BusinessCentre_BusinessCentreId",
                        column: x => x.BusinessCentreId,
                        principalTable: "BusinessCentre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Document_SupportTicket_SupportTicketId",
                        column: x => x.SupportTicketId,
                        principalTable: "SupportTicket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCentre_CompanyId",
                table: "BusinessCentre",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCentre_PersonId",
                table: "BusinessCentre",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessCentre_PersonId1",
                table: "BusinessCentre",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Document_BusinessCentreId",
                table: "Document",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PersonId",
                table: "Document",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_SupportTicketId",
                table: "Document",
                column: "SupportTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_DworkinWiFiSurveyResult_BusinessCentreId",
                table: "DworkinWiFiSurveyResult",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_DworkinWiFiSurveyResult_PersonId",
                table: "DworkinWiFiSurveyResult",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CompanyId",
                table: "Person",
                column: "CompanyId");

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
                name: "Document");

            migrationBuilder.DropTable(
                name: "DworkinWiFiSurveyResult");

            migrationBuilder.DropTable(
                name: "SupportTicket");

            migrationBuilder.DropTable(
                name: "BusinessCentre");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
