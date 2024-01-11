using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SicilNo",
                table: "Calisanlar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_SicilNo",
                table: "Calisanlar",
                column: "SicilNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Calisanlar_SicilNo",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "SicilNo",
                table: "Calisanlar");
        }
    }
}
