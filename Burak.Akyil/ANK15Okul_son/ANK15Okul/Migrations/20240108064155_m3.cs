using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.AlterColumn<int>(
                name: "DiplomaId",
                table: "Ogrenciler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DanismanId",
                table: "Ogrenciler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Ogrenciler",
                column: "DiplomaId",
                unique: true,
                filter: "[DiplomaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.AlterColumn<int>(
                name: "DiplomaId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DanismanId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Ogrenciler",
                column: "DiplomaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
