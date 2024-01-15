using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_Diplomalar_DiplomaId",
                table: "Ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci");

            migrationBuilder.RenameTable(
                name: "Ogrenci",
                newName: "Ogrenciler");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_DiplomaId",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_DiplomaId");

            migrationBuilder.AddColumn<int>(
                name: "DanismanId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Danismanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoyadAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Danismanlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DanismanId",
                table: "Ogrenciler");

            migrationBuilder.RenameTable(
                name: "Ogrenciler",
                newName: "Ogrenci");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_DiplomaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_Diplomalar_DiplomaId",
                table: "Ogrenci",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
