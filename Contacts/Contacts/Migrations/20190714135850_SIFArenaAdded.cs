using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class SIFArenaAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SIFArena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaNumber = table.Column<string>(nullable: true),
                    ArenanName = table.Column<string>(nullable: true),
                    ArenanAddress = table.Column<string>(nullable: true),
                    ArenanZipCode = table.Column<string>(nullable: true),
                    ArenanCity = table.Column<string>(nullable: true),
                    ArenanCountry = table.Column<string>(nullable: true),
                    ArenanDistrict = table.Column<string>(nullable: true),
                    ArenanCategory = table.Column<string>(nullable: true),
                    ArenanPhoneNumbers = table.Column<string>(nullable: true),
                    ArenanCapacity = table.Column<string>(nullable: true),
                    ArenanStanding = table.Column<string>(nullable: true),
                    ArenanBench = table.Column<string>(nullable: true),
                    ArenanChair = table.Column<string>(nullable: true),
                    ArenanSoftChair = table.Column<string>(nullable: true),
                    ArenanHandicapSlots = table.Column<string>(nullable: true),
                    ArenanBuildYear = table.Column<string>(nullable: true),
                    ArenanReBuildYear = table.Column<string>(nullable: true),
                    ArenanLatestInspected = table.Column<string>(nullable: true),
                    ArenanLastChecked = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIFArena", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIFArena");
        }
    }
}
