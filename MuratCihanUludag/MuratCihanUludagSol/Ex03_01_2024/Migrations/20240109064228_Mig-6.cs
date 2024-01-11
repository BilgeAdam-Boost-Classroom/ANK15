using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calisanlar",
                table: "Calisanlar");

            migrationBuilder.RenameTable(
                name: "Calisanlar",
                newName: "Personnel");

            migrationBuilder.RenameIndex(
                name: "IX_Calisanlar_SicilNo",
                table: "Personnel",
                newName: "IX_Personnel_SicilNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel",
                column: "CalisanPrimaryKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel");

            migrationBuilder.RenameTable(
                name: "Personnel",
                newName: "Calisanlar");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_SicilNo",
                table: "Calisanlar",
                newName: "IX_Calisanlar_SicilNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calisanlar",
                table: "Calisanlar",
                column: "CalisanPrimaryKey");
        }
    }
}
