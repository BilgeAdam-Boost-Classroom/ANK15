using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler");

            migrationBuilder.AddForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler",
                column: "DiplomaId",
                principalTable: "Diplomas",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler");

            migrationBuilder.AddForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler",
                column: "DiplomaId",
                principalTable: "Diplomas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
