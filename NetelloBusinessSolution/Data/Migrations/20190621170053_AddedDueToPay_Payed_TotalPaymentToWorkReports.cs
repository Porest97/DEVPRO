using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class AddedDueToPay_Payed_TotalPaymentToWorkReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPayment",
                table: "WorkReport",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentPerHour",
                table: "WorkReport",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountPayed",
                table: "WorkReport",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DueToPay",
                table: "WorkReport",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Payed",
                table: "WorkReport",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountPayed",
                table: "WorkReport");

            migrationBuilder.DropColumn(
                name: "DueToPay",
                table: "WorkReport");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "WorkReport");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPayment",
                table: "WorkReport",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentPerHour",
                table: "WorkReport",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
