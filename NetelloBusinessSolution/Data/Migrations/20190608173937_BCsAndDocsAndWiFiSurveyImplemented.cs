using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class BCsAndDocsAndWiFiSurveyImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessCentre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocumentName = table.Column<string>(nullable: true),
                    DocumentDescription = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    BusinessCentreId = table.Column<int>(nullable: true)
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
                name: "IX_DworkinWiFiSurveyResult_BusinessCentreId",
                table: "DworkinWiFiSurveyResult",
                column: "BusinessCentreId");

            migrationBuilder.CreateIndex(
                name: "IX_DworkinWiFiSurveyResult_PersonId",
                table: "DworkinWiFiSurveyResult",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "DworkinWiFiSurveyResult");

            migrationBuilder.DropTable(
                name: "BusinessCentre");
        }
    }
}
