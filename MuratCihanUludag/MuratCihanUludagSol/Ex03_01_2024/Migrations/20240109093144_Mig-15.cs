using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubeYabanciAnahtar",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Section",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubeYabanciAnahtar",
                table: "Students",
                column: "SubeYabanciAnahtar");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Section_SubeYabanciAnahtar",
                table: "Students",
                column: "SubeYabanciAnahtar",
                principalTable: "Section",
                principalColumn: "SubeTekilAnahtar",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Section_SubeYabanciAnahtar",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubeYabanciAnahtar",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SubeYabanciAnahtar",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Section");
        }
    }
}
