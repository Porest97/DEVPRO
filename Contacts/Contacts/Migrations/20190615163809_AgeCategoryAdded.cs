using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contacts.Migrations
{
    public partial class AgeCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeCategoryId",
                table: "Contact",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AgeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_AgeCategoryId",
                table: "Contact",
                column: "AgeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AgeCategory_AgeCategoryId",
                table: "Contact",
                column: "AgeCategoryId",
                principalTable: "AgeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AgeCategory_AgeCategoryId",
                table: "Contact");

            migrationBuilder.DropTable(
                name: "AgeCategory");

            migrationBuilder.DropIndex(
                name: "IX_Contact_AgeCategoryId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "AgeCategoryId",
                table: "Contact");
        }
    }
}
