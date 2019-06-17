using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class DistrictToClubAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Club",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Club_DistrictId",
                table: "Club",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Club_District_DistrictId",
                table: "Club",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_District_DistrictId",
                table: "Club");

            migrationBuilder.DropIndex(
                name: "IX_Club_DistrictId",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Club");
        }
    }
}
