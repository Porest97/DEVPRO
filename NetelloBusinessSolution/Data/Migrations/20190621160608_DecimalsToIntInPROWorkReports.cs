using Microsoft.EntityFrameworkCore.Migrations;

namespace NetelloBusinessSolution.Data.Migrations
{
    public partial class DecimalsToIntInPROWorkReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROWorkReport_PurchaseOrder_PurchaseOrderId",
                table: "PROWorkReport");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPayment",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeWorked",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentPerHour",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AmountPayed",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddForeignKey(
                name: "FK_PROWorkReport_PurchaseOrder_PurchaseOrderId",
                table: "PROWorkReport",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PROWorkReport_PurchaseOrder_PurchaseOrderId",
                table: "PROWorkReport");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPayment",
                table: "PROWorkReport",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "TimeWorked",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PROWorkReport",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "PaymentPerHour",
                table: "PROWorkReport",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountPayed",
                table: "PROWorkReport",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PROWorkReport_PurchaseOrder_PurchaseOrderId",
                table: "PROWorkReport",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
