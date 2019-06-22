using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class AmountPayedAndPayedAddedToPROWorkReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmountPayed",
                table: "PROWorkReport",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Payed",
                table: "PROWorkReport",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountPayed",
                table: "PROWorkReport");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "PROWorkReport");
        }
    }
}
