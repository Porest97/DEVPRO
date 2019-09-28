﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class SIFClubAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SIFClub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubNumber = table.Column<string>(nullable: true),
                    ClubName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    ClubAddress = table.Column<string>(nullable: true),
                    ClubCity = table.Column<string>(nullable: true),
                    ClubCountry = table.Column<string>(nullable: true),
                    ClubDistrict = table.Column<string>(nullable: true),
                    Organizer = table.Column<string>(nullable: true),
                    HomeArena = table.Column<string>(nullable: true),
                    ActiveIOL = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ClubNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIFClub", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIFClub");
        }
    }
}
