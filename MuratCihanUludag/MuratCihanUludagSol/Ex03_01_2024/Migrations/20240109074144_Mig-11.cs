using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomas_DiplomaId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DiplomaId",
                table: "Students",
                newName: "DanismanYabanciAnahtar");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DiplomaId",
                table: "Students",
                newName: "IX_Students_DanismanYabanciAnahtar");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomas_DanismanYabanciAnahtar",
                table: "Students",
                column: "DanismanYabanciAnahtar",
                principalTable: "Diplomas",
                principalColumn: "DiplomaBirincilAnahtar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomas_DanismanYabanciAnahtar",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DanismanYabanciAnahtar",
                table: "Students",
                newName: "DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DanismanYabanciAnahtar",
                table: "Students",
                newName: "IX_Students_DiplomaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomas_DiplomaId",
                table: "Students",
                column: "DiplomaId",
                principalTable: "Diplomas",
                principalColumn: "DiplomaBirincilAnahtar");
        }
    }
}
