using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class PhoneNumbersImplementedInCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber1",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber2",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber3",
                table: "Company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber1",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "PhoneNumber2",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "PhoneNumber3",
                table: "Company");
        }
    }
}
