using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subeler",
                table: "Subeler");

            migrationBuilder.RenameTable(
                name: "Subeler",
                newName: "Section");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Section",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "SubeTekilAnahtar");

            migrationBuilder.CreateIndex(
                name: "IX_Section_Ad",
                table: "Section",
                column: "Ad",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Section_Ad",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Subeler");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Subeler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subeler",
                table: "Subeler",
                column: "SubeTekilAnahtar");
        }
    }
}
