using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HStats.Migrations
{
    public partial class TSMRefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefereeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeCategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeCategoryTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeCategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeDistrict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeDistrictName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeDistrict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TSMRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    RefNumber = table.Column<string>(nullable: true),
                    Ssn = table.Column<string>(nullable: true),
                    RefereeTypeId = table.Column<int>(nullable: true),
                    RefereeCategoryId = table.Column<int>(nullable: true),
                    RefereeCategoryTypeId = table.Column<int>(nullable: true),
                    RefereeDistrictId = table.Column<int>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSMRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSMRef_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMRef_RefereeCategory_RefereeCategoryId",
                        column: x => x.RefereeCategoryId,
                        principalTable: "RefereeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMRef_RefereeCategoryType_RefereeCategoryTypeId",
                        column: x => x.RefereeCategoryTypeId,
                        principalTable: "RefereeCategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMRef_RefereeDistrict_RefereeDistrictId",
                        column: x => x.RefereeDistrictId,
                        principalTable: "RefereeDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMRef_RefereeType_RefereeTypeId",
                        column: x => x.RefereeTypeId,
                        principalTable: "RefereeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TSMRef_ClubId",
                table: "TSMRef",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMRef_RefereeCategoryId",
                table: "TSMRef",
                column: "RefereeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMRef_RefereeCategoryTypeId",
                table: "TSMRef",
                column: "RefereeCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMRef_RefereeDistrictId",
                table: "TSMRef",
                column: "RefereeDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMRef_RefereeTypeId",
                table: "TSMRef",
                column: "RefereeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TSMRef");

            migrationBuilder.DropTable(
                name: "RefereeCategory");

            migrationBuilder.DropTable(
                name: "RefereeCategoryType");

            migrationBuilder.DropTable(
                name: "RefereeDistrict");

            migrationBuilder.DropTable(
                name: "RefereeType");
        }
    }
}
