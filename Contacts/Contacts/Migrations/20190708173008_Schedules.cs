using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class Schedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    PhoneNumber3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WeekNumber = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    Monday = table.Column<string>(nullable: true),
                    HoursMonday = table.Column<decimal>(nullable: false),
                    Tuesday = table.Column<string>(nullable: true),
                    HoursTuesday = table.Column<decimal>(nullable: false),
                    Wednesday = table.Column<string>(nullable: true),
                    HoursWednesday = table.Column<decimal>(nullable: false),
                    Thursday = table.Column<string>(nullable: true),
                    HoursThursday = table.Column<decimal>(nullable: false),
                    Friday = table.Column<string>(nullable: true),
                    HoursFriday = table.Column<decimal>(nullable: false),
                    Saturday = table.Column<string>(nullable: true),
                    HoursSaturday = table.Column<decimal>(nullable: false),
                    Sunday = table.Column<string>(nullable: true),
                    HoursSunday = table.Column<decimal>(nullable: false),
                    TotalHours = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_PersonId",
                table: "Schedule",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
