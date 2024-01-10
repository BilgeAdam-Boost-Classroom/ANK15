using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomalar_DiplomaId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DiplomaId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DanismanId",
                table: "Students",
                newName: "DanismanYabanciAnahtar");

            migrationBuilder.RenameColumn(
                name: "DiplomaId",
                table: "Students",
                newName: "DiplomaYabanciAnahtar");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DanismanId",
                table: "Students",
                newName: "IX_Students_DanismanYabanciAnahtar");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DiplomaYabanciAnahtar",
                table: "Students",
                column: "DiplomaYabanciAnahtar",
                unique: true,
                filter: "[DiplomaYabanciAnahtar] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Danismanlar_DanismanYabanciAnahtar",
                table: "Students",
                column: "DanismanYabanciAnahtar",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomalar_DiplomaYabanciAnahtar",
                table: "Students",
                column: "DiplomaYabanciAnahtar",
                principalTable: "Diplomalar",
                principalColumn: "DiplomaBirincilAnahtar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Danismanlar_DanismanYabanciAnahtar",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomalar_DiplomaYabanciAnahtar",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DiplomaYabanciAnahtar",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DanismanYabanciAnahtar",
                table: "Students",
                newName: "DanismanId");

            migrationBuilder.RenameColumn(
                name: "DiplomaYabanciAnahtar",
                table: "Students",
                newName: "DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DanismanYabanciAnahtar",
                table: "Students",
                newName: "IX_Students_DanismanId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DiplomaId",
                table: "Students",
                column: "DiplomaId",
                unique: true,
                filter: "[DiplomaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomalar_DiplomaId",
                table: "Students",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "DiplomaBirincilAnahtar");
        }
    }
}
